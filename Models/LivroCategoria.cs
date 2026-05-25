using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotec_MVC_DEV.Models
{
    public class LivroCategoria
    {
        [ForeignKey("LivroId")]
        public int LivroId { get; set; }

        public Livro Livro { get; set; } = null!;

        [ForeignKey("CategoriaId")]
        public int CategoriaId { get; set; }

        public Categoria Categoria { get; set; } = null!;
    }
}