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

        private int GetParametroNumerico(string parametroNumerico)
        {
            int risultato = 0;
            if (parametroNumerico != "")
            {
                risultato = Convert.ToInt16(parametroNumerico);
            }
            return risultato;
        }

        public List<Prodotto> Cerca()
        {
            using (AzioniCerca azioni = new AzioniCerca())
            {
                int prezzoA = 1000;
                if (PrezzoA.Text != "")
                {
                    prezzoA = Convert.ToInt16(PrezzoA.Text);
                }
                return azioni.CercaDatabaseProdotti(Titolo.Text, Autore.Text, Editore.Text, Genere.Text, 
                                                    Categoria.Text, Novità.Text, GetParametroNumerico(Edizione.Text), 
                                                    GetParametroNumerico(PrezzoDA.Text), prezzoA);
            }
        }

        protected void Cerca_Click(object sender, EventArgs e)
        {
            ListaRisultati.DataBind();
        }
    }
}