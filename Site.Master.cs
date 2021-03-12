using System;
using System.Web.UI;
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
    }
}