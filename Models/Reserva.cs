using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotec_MVC_DEV.Models
{
    public class Reserva
    {
        [Key]
        public int Id { get; set; }

        public DateTime DataReserva { get; set; }

        public DateTime? DataEmprestimo { get; set; }

        public DateTime? DataPrevistaDevolucao { get; set; }

        public string? DanoLivro { get; set; }

        [Required]
        [StringLength(1)]
        public string Status { get; set; } = null!;
        // E = espera; P = posse; A = atrasado; F = finalizada;
    }
}