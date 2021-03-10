using System;
using System.ComponentModel.DataAnnotations;

namespace WebLibreria.Models
{
    public class ProdottoCarrello
    {
        [Key]
        public string ProdottoCarrelloID { get; set; }

        public string CarrelloID { get; set; }

        public int Quantità { get; set; }

        public DateTime DataOrdine { get; set; }

        public virtual Prodotto Prodotto { get; set; }
    }
}