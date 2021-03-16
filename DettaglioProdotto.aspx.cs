using System;
using System.Linq;
using System.Web.ModelBinding;
using System.Web.UI;
using WebLibreria.Models;

namespace WebLibreria
{
    public partial class DettaglioProdotto : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Prodotto> GetProdotto([QueryString("ProdottoID")] int prodottoId)
        {
            var _db = new ContestoProdotto();
            IQueryable<Prodotto> query = _db.Prodotti;
            if (prodottoId > 0)
            {
                query = query.Where(p => p.ProdottoID == prodottoId);
            }
            return query;
        }

    }
}