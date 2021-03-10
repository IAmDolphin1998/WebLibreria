using System;
using WebLibreria.Logic;

namespace WebLibreria
{
    public partial class AggiungiCarrello : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string idRichiesta = Request.QueryString["ProdottoID"];
            int idProdotto;
            if (!string.IsNullOrEmpty(idRichiesta) && int.TryParse(idRichiesta, out idProdotto))
            {
                using (AzioniCarrello utenteCarrello = new AzioniCarrello())
                {
                    utenteCarrello.AggiungiAlCarrello(Convert.ToInt16(idRichiesta));
                }
            }
            Response.Redirect("Carrello.aspx");
        }
    }
}