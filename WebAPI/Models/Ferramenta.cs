using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Ferramenta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public string  Id { get; set; }
        public string NomeDaFerramenta { get; set; }
        public string IdDoDono { get; set; }
        public long Preco { get; set;  }

    }
}
