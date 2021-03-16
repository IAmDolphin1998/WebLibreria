using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebLibreria.Models
{
    public class Ordine
    {
        [Required]
        public List<ProdottoCarrello> prodottiOrdinati { get; set; }

        [Required]
        public DateTime dataOrdine { get; set; }

        [Required]
        public int prezzoOrdine { get; set; }
    }
}