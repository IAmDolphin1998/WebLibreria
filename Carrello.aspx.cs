using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebLibreria.Logic;
using WebLibreria.Models;

namespace WebLibreria
{
    public partial class Carrello : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (AzioniCarrello azioni = new AzioniCarrello())
            {
                decimal totaleCarrello = 0;
                totaleCarrello = azioni.GetTotale();
                if (totaleCarrello > 0)
                {
                    Totale.Text = String.Format("{0:c}", totaleCarrello);
                }
                else
                {
                    Totale.Text = "";
                    TitoloCarrello.InnerText = "Il carrello è vuoto!";
                    Aggiorna.Visible = false;
                }
            }
        }

        public void CreaOrdine()
        {
            using (ContestoProdotto _db = new ContestoProdotto())
            {
                using (AzioniCarrello azioni = new AzioniCarrello())
                {
                    var ordine = new Ordine
                    {
                        Utente_Email = HttpContext.Current.User.Identity.Name,
                        ProdottiOrdinati = _db.ProdottiCarrello.Where(p => p.CarrelloID == HttpContext.Current.User.Identity.Name).Select(p => p.Prodotto.ProdottoID).ToList(),
                        OrdineID = Guid.NewGuid().ToString(),
                        DataOrdine = DateTime.Now,
                        PrezzoOrdine = Convert.ToDouble(Totale.Text.Split(' ')[0])
                    };
                    using (AzioniUtente azioniUtente = new AzioniUtente())
                    {
                        azioniUtente.AggiungiOrdine(ordine);
                    }
                }
            }
        }

        public void AggiornaOggettiCarrello(bool acquisto)
        {
            using (AzioniCarrello azioni = new AzioniCarrello())
            {
                string ProdottoCarrelloID = azioni.GetID();

                AzioniCarrello.ProdottoCarrelloAggiornato[] prodottiCarrelloAggiornati = new AzioniCarrello.ProdottoCarrelloAggiornato[ListaCarrello.Rows.Count];
                for (int i = 0; i < ListaCarrello.Rows.Count; i++)
                {
                    _ = new OrderedDictionary();
                    IOrderedDictionary ValoriRiga = GetValori(ListaCarrello.Rows[i]);
                    prodottiCarrelloAggiornati[i].ProdottoID = Convert.ToInt16(ValoriRiga["Prodotto.ProdottoID"]);

                    if (acquisto)
                    {
                        prodottiCarrelloAggiornati[i].RimuoviProdotto = true;
                    }
                    else
                    {
                        _ = new CheckBox();
                        CheckBox cbRimouvi = (CheckBox)ListaCarrello.Rows[i].FindControl("Rimuovi");
                        prodottiCarrelloAggiornati[i].RimuoviProdotto = cbRimouvi.Checked;
                    }

                    _ = new TextBox();
                    TextBox tbQuantità = (TextBox)ListaCarrello.Rows[i].FindControl("QuantitàProdotto");
                    prodottiCarrelloAggiornati[i].Quantità = Convert.ToInt16(tbQuantità.Text.ToString());
                }
                azioni.AggiornaDatabaseProdottiCarrello(ProdottoCarrelloID, prodottiCarrelloAggiornati);
                ListaCarrello.DataBind();
                Totale.Text = String.Format("{0:c}", azioni.GetTotale().ToString());
            }
        }

        public static IOrderedDictionary GetValori(GridViewRow riga)
        {
            IOrderedDictionary Valori = new OrderedDictionary();
            foreach (DataControlFieldCell cella in riga.Cells)
            {
                cella.ContainingField.ExtractValuesFromCell(Valori, cella, riga.RowState, true);
            }
            return Valori;
        }

        public List<ProdottoCarrello> GetProdottiCarrello()
        {
            AzioniCarrello azioni = new AzioniCarrello();

            return azioni.GetProdottiCarrello();
        }

        protected void Aggiorna_Click(object sender, EventArgs e)
        {
            AggiornaOggettiCarrello(false);
        }

        protected void ConfermaAcquisto_Click(object sender, EventArgs e)
        {
            if (Page.User.Identity.IsAuthenticated)
            {
                CreaOrdine();
                AggiornaOggettiCarrello(true);
            }
            else
            {
                FormsAuthentication.RedirectToLoginPage();
            }
        }
    }
}