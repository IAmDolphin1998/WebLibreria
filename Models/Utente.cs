using System;
using System.ComponentModel.DataAnnotations;

namespace WebLibreria.Models
{
    public class Utente
    {
     
        [Required, Display(Name = "Nome")]
        public string Nome { get; set; }

        [Required, Display(Name = "Cognome")]
        public string Cognome { get; set; }

        [Required]
        public string SessoUtente { get; set; }

        [Required, Display(Name = "Data di nascita")]
        public DateTime DataNascita { get; set; }

        [Required, Display(Name = "Città di nascita")]
        public string CittàNascita { get; set; }

        [Key, Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}