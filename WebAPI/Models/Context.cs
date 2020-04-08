using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WEBAPI.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options)
        {   
        }

        public DbSet<Ferramenta> Ferramentas { get; set; }
        public DbSet<Aluguel> Algueis { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }



    }
}
