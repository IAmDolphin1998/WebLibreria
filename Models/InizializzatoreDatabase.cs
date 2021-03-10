using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace WebLibreria.Models
{
    public class InizializzatoreDatabase : DropCreateDatabaseIfModelChanges<ContestoProdotto>
    {
        protected override void Seed(ContestoProdotto contesto)
        {
            GetProdotti().ForEach(p => contesto.Prodotti.Add(p));
        }

        private static List<Prodotto> GetProdotti()
        {
            var prodotti = new List<Prodotto>
            {
                new Prodotto
                {
                    ProdottoID = 1,
                    Titolo = "Il sistema. Potere, politica affari: storia segreta della magistratura italiana",
                    Descrizione = "Incalzato dalle domande di Alessandro Sallusti, in questo libro Palamara racconta cosa sia il “Sistema” che ha pesantemente influenzato la politica italiana.",
                    ISBN = "9788817157162",
                    ImmaginePercorso = "sistema.png",
                    Autore = "Alessandro Sallusti",
                    Editore = "Rizzoli",
                    Genere = "Diritto",
                    Categoria = "Politica",
                    Edizione = 2,
                    NumeroPagine = 288,
                    Prezzo = 18.05,
                    Disponibilità = true,
                    DataInserimento = new DateTime(2021,1,1),
                    Novità = "Novità 1"
                },
                new Prodotto
                {
                    ProdottoID = 2,
                    Titolo = "Una terra promessa",
                    Descrizione = "Un appassionante e personalissimo racconto in presa diretta del Presidente che ci ha dato la forza di credere nel potere della democrazia.",
                    ISBN = "9788811149873",
                    ImmaginePercorso = "promessa.jpg",
                    Autore = "Barack Obama",
                    Editore = "Garzanti",
                    Genere = "Scienze politiche e sociali",
                    Categoria = "Politica",
                    Edizione = 1,
                    NumeroPagine = 848,
                    Prezzo = 26.60,
                    Disponibilità = false,
                    DataInserimento = new DateTime(2020,1,1),
                    Novità = "Novità 2"
                },
                new Prodotto
                {
                    ProdottoID = 3,
                    Titolo = "Ciao",
                    Descrizione = "Un doppiopetto grigio, il Borsalino in mano, un velo di brillantina sui capelli, lo sguardo basso. Sotto un cielo che affonda nel rosa di un tramonto infinito, un ragazzo degli anni Cinquanta torna dal passato, si ferma sul pianerottolo della casa di famiglia e aspetta il figlio, ormai adulto.",
                    ISBN = "9788817084260",
                    ImmaginePercorso = "ciao.jpg",
                    Autore = "Walter Veltroni",
                    Editore = "Rizzoli",
                    Genere = "Narrativa",
                    Categoria = "Storia",
                    Edizione = 3,
                    NumeroPagine = 248,
                    Prezzo = 9.25,
                    Disponibilità = true,
                    DataInserimento = new DateTime(2015,1,1),
                    Novità = "Novità 3"
                },
                new Prodotto
                {
                    ProdottoID = 4,
                    Titolo = "La ragazza del treno",
                    Descrizione = "La vita di Rachel non è di quelle che vorresti spiare. Vive sola, non ha amici, e ogni mattina prende lo stesso treno, che la porta dalla periferia di Londra al suo grigio lavoro in città. Quel viaggio sempre uguale è il momento preferito della sua giornata.",
                    ISBN = "9788856637779",
                    ImmaginePercorso = "treno.jpg",
                    Autore = "Paula Hawkins",
                    Editore = "Piemme",
                    Genere = "Narrativa",
                    Categoria = "Storia",
                    Edizione = 3,
                    NumeroPagine = 306,
                    Prezzo = 19.50,
                    Disponibilità = false,
                    DataInserimento = new DateTime(2015,1,1),
                    Novità = "Novità 4"
                },
                new Prodotto
                {
                    ProdottoID = 5,
                    Titolo = "La crisi, e poi?",
                    Descrizione = "Come siamo arrivati fino a questo punto? Sembrava che il mondo stesse procedendo per il verso giusto, la crescita economica era la più rapida della storia e tutto lasciava presagire che sarebbe continuata per molti decenni, grazie alla presenza - su scala mondiale - di un abbondante risparmio e a progressi tecnologici straordinari.",
                    ISBN = "9788864110004",
                    ImmaginePercorso = "crisi.jpg",
                    Autore = "Jacques Attali",
                    Editore = "Fazi",
                    Genere = "Economia e management",
                    Categoria = "Economia",
                    Edizione = 8,
                    NumeroPagine = 142,
                    Prezzo = 8,
                    Disponibilità = true,
                    DataInserimento = new DateTime(2009,1,1),
                    Novità = "Novità 5"
                }
            };

            return prodotti;
        }
    }
}