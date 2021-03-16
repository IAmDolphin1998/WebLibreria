using System;
using System.Web.UI;
using WebLibreria.Logic;

namespace WebLibreria.Account
{
    public partial class Registrazione : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CreaUtente_Click(object sender, EventArgs e)
        {
            using (AzioniUtente azioni = new AzioniUtente())
            {
                azioni.AggiungiUtente(Nome.Text, Cognome.Text, SessoScelta.Text, DataNascita.Text, CittàNascitaScelta.Text, Email.Text, Password.Text);
                Response.Redirect("~/ListaProdotti.aspx");  
            }
        }              
    }
}