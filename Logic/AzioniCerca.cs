using System;
using System.Collections.Generic;
using WebLibreria.Models;
using System.Linq;

namespace WebLibreria.Logic
{
    public class AzioniCerca : IDisposable
    {
        private ContestoProdotto _db = new ContestoProdotto();

        public List<Prodotto> CercaDatabaseProdotti(string[] parametri)
        {
            List<Prodotto> prodottiTrovati = new List<Prodotto>();
            foreach (var parametro in parametri)
            {
                var Prodotto = (from c in _db.Prodotti
                                where c.Titolo == parametro || c.Autore == parametro || c.Editore == parametro ||
                                      c.Genere == parametro || c.Categoria == parametro || c.Novità == parametro
                                select c).FirstOrDefault();
                if (Prodotto != null && !prodottiTrovati.Contains(Prodotto))
                {
                    prodottiTrovati.Add(Prodotto);
                }
            }
            return prodottiTrovati;

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