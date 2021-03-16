using System;
using System.Web.UI;
using System.Web.Security;
using WebLibreria.Logic;

namespace WebLibreria
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void Page_PreRender(object sender, EventArgs e)
        {
            using (AzioniCarrello azioni = new AzioniCarrello())
            {
                string contatore = string.Format("Carrello ({0})", azioni.GetConta());
                NumeroProdotti.InnerText = contatore;
            }
        }

        protected void Esci_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            FormsAuthentication.RedirectToLoginPage();
        }
       
    }
}