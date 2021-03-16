using System;
using System.Web.Security;
using System.Web.UI;
using WebLibreria.Logic;

namespace WebLibreria.Account
{
    public partial class Accedi : Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LogIn_Authenticate(object sender, EventArgs e)
        {
            using (AzioniUtente azioni = new AzioniUtente())
            {
                var utente = azioni.ControllaCredenziali(LogIn.UserName, LogIn.Password);
                if (utente == null)
                {
                    LogIn.FailureText = "Nome utente e/o Password errati!";
                }
                else
                {
                    FormsAuthentication.RedirectFromLoginPage(LogIn.UserName, LogIn.RememberMeSet);
                }
            }
        }
    }
}