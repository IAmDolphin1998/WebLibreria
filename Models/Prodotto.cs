using System;
using System.ComponentModel.DataAnnotations;

namespace WebLibreria.Models
{
    public class Prodotto
    {
        [ScaffoldColumn(false)]
        public int ProdottoID { get; set; }

        [Required]
        public string Titolo { get; set; }

        [Required]
        public string Descrizione { get; set; }

        [Required, StringLength(13)]
        public string ISBN { get; set; }

        [Required]
        public string ImmaginePercorso { get; set; }

        [Required]
        public string Autore { get; set; }

        [Required]
        public string Editore { get; set; }

        [Required]
        public string Genere { get; set; }

        [Required]
        public string Categoria { get; set; }

        [Required]
        public int Edizione { get; set; }

        [Required]
        public int NumeroPagine { get; set; }

        [Required]
        public double Prezzo { get; set; }

        [Required]
        public bool Disponibilità { get; set; }

        [Required]
        public DateTime DataInserimento { get; set; }

        [Required]
        public string Novità { get; set; }
    }
}