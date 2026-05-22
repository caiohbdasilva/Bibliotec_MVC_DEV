using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotec_MVC_DEV.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required] //Obrigatória
        [StringLength(20)] // Tamanho da String
        public String Matricula { get; set; } =null!;

        public bool Ativo { get; set; }

        [Required]
        [StringLength(100)]
        public String Nome { get; set; } =null!;

        [Required]
        [StringLength(100)]
        public String Email { get; set; } = null!;

        [Required]
        [StringLength(50)]
        public String Senha { get; set; } = null!;

        [Required]
        [StringLength(50)]
        public String NumCel { get; set; } = null!;

        public bool TipoBib { get; set; } // 0 - Aluno / 1 - Bibliotecária

        public ICollection<Reserva> Reservas { get; set; } = new List<Reserva>();
    }
}