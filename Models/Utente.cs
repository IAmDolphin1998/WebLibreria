using System;
using System.ComponentModel.DataAnnotations;

namespace WebLibreria.Models
{
    public class Utente
    {
        [Required]
        public string Nome { get; set; }

        [Required]
        public string Cognome { get; set; }

        [Required]
        public string SessoUtente { get; set; }

        [Required]
        public DateTime DataNascita { get; set; }

        [Required]
        public string CittàNascita { get; set; }

        [Key]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}