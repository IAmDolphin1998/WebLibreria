using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebLibreria.Models;

namespace WebLibreria.Logic
{
    public class AzioniCarrello : IDisposable
    {
        public string ProdottoCarrelloID { get; set; }

        private ContestoProdotto _db = new ContestoProdotto();

        public const string ChiaveSessione = "IDCarrello";

        public void AggiungiAlCarrello(int id)
        {
            ProdottoCarrelloID = GetID();

            var carrello = _db.ProdottiCarrello.SingleOrDefault(c => c.CarrelloID == ProdottoCarrelloID && c.Prodotto.ProdottoID == id);
            if (carrello == null)
            {
                carrello = new ProdottoCarrello
                {
                    ProdottoCarrelloID = Guid.NewGuid().ToString(),
                    CarrelloID = ProdottoCarrelloID,
                    Prodotto = _db.Prodotti.SingleOrDefault(p => p.ProdottoID == id),
                    Quantità = 1
                };
                _db.ProdottiCarrello.Add(carrello);
            }
            else
            {
                carrello.Quantità++;
            }
            _db.SaveChanges();
        }

        public void AggiornaDatabaseProdottiCarrello(string CarrelloID, ProdottoCarrelloAggiornato[] ProdottiCarrelloAggiornati)
        {
            using (var db = new ContestoProdotto())
            {
                int NumeroProdottiCarrello = ProdottiCarrelloAggiornati.Count();
                List<ProdottoCarrello> CarrelloAttuale = GetProdottiCarrello();
                foreach (var ProdottoCarrello in CarrelloAttuale)
                {
                    for (int i = 0; i < NumeroProdottiCarrello; i++)
                    {
                        if (ProdottoCarrello.Prodotto.ProdottoID == ProdottiCarrelloAggiornati[i].ProdottoID)
                        {
                            if (ProdottiCarrelloAggiornati[i].Quantità < 1 || ProdottiCarrelloAggiornati[i].RimuoviProdotto == true)
                            {
                                RimuoviProdotto(CarrelloID, ProdottoCarrello.Prodotto.ProdottoID);
                            }
                            else
                            {
                                AggiornaProdotto(CarrelloID, ProdottoCarrello.Prodotto.ProdottoID, ProdottiCarrelloAggiornati[i].Quantità);
                            }
                        }
                    }
                }
            }
        }

        public void AggiornaProdotto(string CarrelloID, int ProdottoID, int Quantità)
        {
            using (var db = new ContestoProdotto())
            {
                var Prodotto = (from c in db.ProdottiCarrello
                                where c.CarrelloID == CarrelloID && c.Prodotto.ProdottoID == ProdottoID
                                select c).FirstOrDefault();
                if (Prodotto != null)
                {
                    Prodotto.Quantità = Quantità;
                    db.SaveChanges();
                }
            }
        }

        public void RimuoviProdotto(string CarrelloID, int ProdottoID)
        {
            using (var db = new ContestoProdotto())
            {
                var Prodotto = (from c in db.ProdottiCarrello
                                where c.CarrelloID == CarrelloID && c.Prodotto.ProdottoID == ProdottoID
                                select c).FirstOrDefault();
                if (Prodotto != null)
                {
                    db.ProdottiCarrello.Remove(Prodotto);
                    db.SaveChanges();
                }
            }
        }

        public int GetConta()
        {
            ProdottoCarrelloID = GetID();
            int? conta = (from ProdottoCarrello in _db.ProdottiCarrello
                          where ProdottoCarrello.CarrelloID == ProdottoCarrelloID
                          select (int?)ProdottoCarrello.Quantità).Sum();
            return conta ?? 0;
        }

        public decimal GetTotale()
        {
            ProdottoCarrelloID = GetID();
            decimal? totale = decimal.Zero;
            totale = (decimal?)(from ProdottoCarrello in _db.ProdottiCarrello
                                where ProdottoCarrello.CarrelloID == ProdottoCarrelloID
                                select (int?)ProdottoCarrello.Quantità * ProdottoCarrello.Prodotto.Prezzo).Sum();
            return totale ?? decimal.Zero;
        }

        public List<ProdottoCarrello> GetProdottiCarrello()
        {
            ProdottoCarrelloID = GetID();

            return _db.ProdottiCarrello.Where(c => c.CarrelloID == ProdottoCarrelloID).ToList();
        }

        public string GetID()
        {
            if (HttpContext.Current.Session[ChiaveSessione] == null)
            {
                if (!string.IsNullOrWhiteSpace(HttpContext.Current.User.Identity.Name))
                {
                    HttpContext.Current.Session[ChiaveSessione] = HttpContext.Current.User.Identity.Name;
                }
                else
                {
                    Guid IDCarrelloTmp = Guid.NewGuid();
                    HttpContext.Current.Session[ChiaveSessione] = IDCarrelloTmp.ToString();
                }
            }
            return HttpContext.Current.Session[ChiaveSessione].ToString();
        }

        public struct ProdottoCarrelloAggiornato
        {
            public bool RimuoviProdotto;
            public int Quantità;
            public int ProdottoID;
        }

        public void Dispose()
        {
            if (_db != null)
            {
                _db.Dispose();
                _db = null;
            }
        }
    }
}