using System;
using System.Collections.Generic;
using System.Web.UI;
using WebLibreria.Models;
using WebLibreria.Logic;

namespace WebLibreria
{
    public partial class CercaProdotto : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public List<Prodotto> Cerca()
        {
            using (AzioniCerca azioni = new AzioniCerca())
            {
                string[] parametri = { Titolo.Text, Autore.Text, Editore.Text, 
                                       Genere.Text, Categoria.Text, Novità.Text};
                return azioni.CercaDatabaseProdotti(parametri);
            }
        }

        protected void Cerca_Click(object sender, EventArgs e)
        {
            ListaRisultati.DataBind();
        }
    }
}