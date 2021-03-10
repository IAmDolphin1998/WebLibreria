using System;
using System.Linq;
using System.Web.UI;
using WebLibreria.Models;

namespace WebLibreria
{
    public partial class ListaProdotti : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Prodotto> GetProdotti() => new ContestoProdotto().Prodotti;
    }
}