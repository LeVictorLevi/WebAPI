using System;
using System.Collections;
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
    public class FerramentasController : ControllerBase
    {
        private readonly Context _context;

        public FerramentasController(Context context)
        {
            _context = context;
        }


        // GET: api/Ferramentas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ferramenta>>> GetFerramentas()
        {
            return await _context.Ferramentas.ToListAsync();
        }

        // GET: api/Ferramentas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ferramenta>> GetFerramentas(string id)
        {
            var todoItem = await _context.Ferramentas.FindAsync(id);
            if (todoItem == null)
            {
                return NotFound();
            }
            
            return todoItem;
        }

        // GET: api/Ferramentas/PorUsuario/id
        [HttpGet]
        [Route("PorUsuario/{id}")]
        public async Task<ActionResult<List<Ferramenta>>> GetFerramentasPorUsuario(string id)
        {
            return  _context.Ferramentas.Where(ferramenta => ferramenta.IdDoDono == id).ToList();
        }


        // GET: api/Ferramentas/NumeroDeVezesAlugada/id
        [HttpGet]
        [Route("NumeroDeVezesAlugada/{id}")]
        public async Task<ActionResult<int>> GetNumeroDeVezesAlugada(string id)
        {
            var todoItem = _context.Algueis.Where(aluguel => aluguel.IdFerramenta == id).ToList();
            return  todoItem.Count;

        }





        // POST: api/Ferramentas
        [HttpPost]
        public async Task<ActionResult<Ferramenta>> PostFerramentas(Ferramenta ferramenta)
        {
            _context.Ferramentas.Add(ferramenta);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetTodoItem", new { id = todoItem.FerramentaID }, todoItem);
            return CreatedAtAction(nameof(GetFerramentas), new { Id = ferramenta.Id }, ferramenta);
        }




        // DELETE: api/Ferramentas/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Ferramenta>> DeleteTodoItem(string id)
        {
            var todoItem = await _context.Ferramentas.FindAsync(id);
            if (todoItem == null)
            {
                return NotFound();
            }

            _context.Ferramentas.Remove(todoItem);
            await _context.SaveChangesAsync();

            return todoItem;
        }

        private bool FerramentasExists(string id)
        {
            return _context.Ferramentas.Any(e => e.Id == id);
        }
    }
}
