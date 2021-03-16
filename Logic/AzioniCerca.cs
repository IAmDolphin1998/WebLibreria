using System;
using System.Collections.Generic;
using WebLibreria.Models;
using System.Linq;

namespace WebLibreria.Logic
{
    public class AzioniCerca : IDisposable
    {
        private ContestoProdotto _db = new ContestoProdotto();

        public List<Prodotto> CercaDatabaseProdotti(string titolo, string autore, string editore, string genere, string categoria, string novità, int edizione, int prezzoDA, int prezzoA)
        {
            //Ottimizzare logica di ricerca!!
            return (from c in _db.Prodotti
                    where (c.Titolo == titolo || c.Autore == autore || c.Editore == editore ||
                           c.Genere == genere || c.Categoria == categoria || c.Novità == novità ||
                           c.Edizione == edizione) && (c.Prezzo >= prezzoDA && c.Prezzo <= prezzoA)
                    select c).ToList(); 
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