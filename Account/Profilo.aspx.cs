using System;
using System.Web.UI;
using WebLibreria.Models;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Data;

namespace WebLibreria.Account
{
    public partial class Profilo : Page
    {
        private bool FiltroON = false;

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

        public IQueryable<Ordine> GetOrdiniUtente()
        {
            ContestoProdotto _db = new ContestoProdotto();

            if (FiltroON)
            {
                var numeriFascia = SceltaFasciaPrezzo.Text.Split('-');
                var minFascia = Convert.ToDouble(numeriFascia[0]);
                var maxFascia = Convert.ToDouble(numeriFascia[1]);

                var numeroMesi = Convert.ToInt32(SceltaMesi.SelectedValue);
                var dataRetroso = DateTime.Now.AddMonths(-numeroMesi);

                return _db.Ordini.Where(o => o.PrezzoOrdine > minFascia && o.PrezzoOrdine < maxFascia && DateTime.Compare(o.DataOrdine, dataRetroso) >= 0);
            }
            else
            {
                return _db.Ordini.Where(o => o.Utente_Email == HttpContext.Current.User.Identity.Name);
            }
                 
        }

        protected void Filtra_Click(object sender, EventArgs e)
        {
            FiltroON = true;
            StoricoDeiOrdini.DataBind();
            FiltroON = false;
        }
    }
}