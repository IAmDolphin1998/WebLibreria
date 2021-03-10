using System;
using System.ComponentModel.DataAnnotations;

namespace WebLibreria.Models
{
    public class Prodotto
    {
        [ScaffoldColumn(false)]
        public int ProdottoID { get; set; }

        [Required, StringLength(100), Display(Name = "Titolo")]
        public string Titolo { get; set; }

        [Required, StringLength(1000), Display(Name = "Descrizione prodotto")]
        public string Descrizione { get; set; }

        [Required, StringLength(13), Display(Name = "ISBN")]
        public string ISBN { get; set; }

        [Required]
        public string ImmaginePercorso { get; set; }

        [Required, Display(Name = "Autore")]
        public string Autore { get; set; }

        [Required, Display(Name = "Editore")]
        public string Editore { get; set; }

        [Required, Display(Name = "Genere")]
        public string Genere { get; set; }

        [Required, Display(Name = "Categoria")]
        public string Categoria { get; set; }

        [Required, Display(Name = "Edizione")]
        public int Edizione { get; set; }

        [Required, Display(Name = "Numero di pagine")]
        public int NumeroPagine { get; set; }

        [Required, Display(Name = "Prezzo")]
        public double Prezzo { get; set; }

        [Required]
        public bool Disponibilità { get; set; }

        [Required, Display(Name = "Data di pubblicazione")]
        public DateTime DataInserimento { get; set; }

        [Required, Display(Name = "Novità")]
        public string Novità { get; set; }
    }
}