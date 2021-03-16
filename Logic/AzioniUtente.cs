using System;
using System.Linq;
using WebLibreria.Models;

namespace WebLibreria.Logic
{
    public class AzioniUtente : IDisposable
    {
        private ContestoProdotto _db = new ContestoProdotto();

        public void AggiungiUtente(string nome, string cognome, string sesso, string dataNascita, string cittàNascita, string email, string password)
        {
            var utente = _db.UtentiRegistrati.SingleOrDefault(u => u.Email == email && u.Password == password);
            if (utente == null)
            {
                utente = new Utente
                {
                    Nome = nome,
                    Cognome = cognome,
                    SessoUtente = sesso,
                    DataNascita = Convert.ToDateTime(dataNascita),
                    CittàNascita = cittàNascita,
                    Email = email,
                    Password = password

                };
                _db.UtentiRegistrati.Add(utente);
            }
            _db.SaveChanges();
        }

        public Utente ControllaCredenziali(string email, string password) => _db.UtentiRegistrati.SingleOrDefault(u => u.Email == email && u.Password == password);

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