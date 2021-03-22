using System;
using System.Web.UI;
using WebLibreria.Models;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Collections.Generic;

namespace WebLibreria.Account
{
    public partial class Profilo : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        public Utente GetUtente()
        {
            using (ContestoProdotto _db = new ContestoProdotto())
            {
                if (!Page.User.Identity.IsAuthenticated)
                {
                    FormsAuthentication.RedirectToLoginPage();
                    return null;
                }
                else
                {
                    return _db.UtentiRegistrati.Single(u => u.Email == HttpContext.Current.User.Identity.Name);
                }       
            }
        }

        public IQueryable<Ordine> GetOrdiniUtente() => new ContestoProdotto().Ordini.Where(o => o.Utente_Email == HttpContext.Current.User.Identity.Name);

        //public IQueryable<Prodotto> ProdottiOrdinati_GetData()
        //{
        //    return null;
        //}
    }
}