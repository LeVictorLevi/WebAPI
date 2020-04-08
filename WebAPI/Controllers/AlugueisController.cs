using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Models;
using WEBAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlugueisController : ControllerBase
    {
        private readonly Context _context;

        public AlugueisController(Context context)
        {
            _context = context;
        }

        // GET: api/Alugueis
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Aluguel>>> GetAlugueis()
        {
            return await _context.Algueis.ToListAsync();
        }

        // GET: api/Alugueis/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Aluguel>> GetAlugueis(string id)
        {
            var todoItem = await _context.Algueis.FindAsync(id);
            if (todoItem == null)
            {
                return NotFound();
            }
            
            return todoItem;
        }

        // GET: api/Alugueis/DeUsuario/id
        [HttpGet]
        [Route("DeUsuario/{id}")]
        public ActionResult<List<Aluguel>> GetAlugueisDeUsuario(string id)
        {
            return _context.Algueis.Where(aluguel => aluguel.IdLocador == id).ToList();
        }





        // POST: api/Alugueis
        [HttpPost]
        public async Task<ActionResult<Aluguel>> PostAlugueis(Aluguel aluguel)
        {
            _context.Algueis.Add(aluguel);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetTodoItem", new { id = todoItem.FerramentaID }, todoItem);
            return CreatedAtAction(nameof(GetAlugueis), new { Id = aluguel.Id }, aluguel);
        }






        // DELETE: api/Alugueis/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Aluguel>> DeleteAlugueis(string id)
        {
            var aluguel = await _context.Algueis.FindAsync(id);
            if (aluguel == null)
            {
                return NotFound();
            }

            _context.Algueis.Remove(aluguel);
            await _context.SaveChangesAsync();

            return aluguel;
        }

        private bool FerramentasExists(string id)
        {
            return _context.Algueis.Any(e => e.Id == id);
        }
    }
}
