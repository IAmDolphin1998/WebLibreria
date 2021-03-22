using System.ComponentModel.DataAnnotations;

namespace WebLibreria.Models
{
    public class ProdottoCarrello
    {
        [Key]
        public string ProdottoCarrelloID { get; set; }

        [Required]
        public string CarrelloID { get; set; }

        [Required]
        public int Quantità { get; set; }

        [Required]
        public virtual Prodotto Prodotto { get; set; }
    }
}