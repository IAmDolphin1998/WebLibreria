using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebLibreria.Models
{
    public class Ordine
    {
        [Key]
        public string OrdineID { get; set; }

        [Required]
        public string Utente_Email { get; set; }

        [Required]
        public DateTime DataOrdine { get; set; }

        [Required]
        public double PrezzoOrdine { get; set; }

        [Required]
        public ICollection<int> ProdottiOrdinati { get; set; }
    }
}