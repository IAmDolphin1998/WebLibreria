using System.Data.Entity;

namespace WebLibreria.Models 
{
    public class ContestoProdotto : DbContext
    {
        public ContestoProdotto() : base("WebLibreria")
        {
        }
        public DbSet<Prodotto> Prodotti { get; set; }
        public DbSet<ProdottoCarrello> ProdottiCarrello { get; set; }
    } 
}