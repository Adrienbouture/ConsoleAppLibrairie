using System;
using System.Collections.Generic;

namespace ConsoleAppLibrairie
{
    public class Librairie
    {
        private string nomLibrairie;
        private string adresseNumRue;
        private int adresseCodePostal;
        private string adresseVille;
        private string mail;
        private int telephone;
        private Collection lesLivres;

        public Librairie(string nom, string numRue, int codePostal, string ville, string email, int phone)
        {
            nomLibrairie = nom;
            adresseNumRue = numRue;
            adresseCodePostal = codePostal;
            adresseVille = ville;
            mail = email;
            telephone = phone;
            lesLivres = new Collection();
        }

        public void AjouterLivre(object livre)
        {
            lesLivres.AjouterObjet(livre);
        }

        public void SupprimerLivre(int numIndex)
        {
            lesLivres.SupprimerObjetIndex(numIndex);
        }

        public Collection GetLivres()
        {
            return lesLivres;
        }

        public void AfficherLibrairie()
        {
            Console.WriteLine("Nom: {0}", nomLibrairie);
            Console.WriteLine("Adresse: {0}, {1}, {2}", adresseNumRue, adresseCodePostal, adresseVille);
            Console.WriteLine("Email: {0}", mail);
            Console.WriteLine("Téléphone: {0}", telephone);
        }

        public void AfficherLivres()
        {
            foreach (Livre livre in lesLivres.GetCollection())
            {
                Console.WriteLine("Numéro du livre {0}", livre.GetNumLivre());
                Console.WriteLine("Titre du livre {0}",livre.GetTitreLivre());
                Console.WriteLine("Auteur du livre {0}", livre.GetAuteurLivre());
                Console.WriteLine("Prix du livre {0}", livre.GetPrixLivre());
                Console.WriteLine("Stock du livre {0}", livre.GetStockLivre());
            }
        }


        public Livre MoinsCher()
        {
            Livre livreMoinsCher = null;
            double prixMinimum = double.MaxValue;
            foreach (Livre livre in lesLivres.GetCollection())
            {
                if (livre.GetPrixLivre() < prixMinimum)
                {
                    livreMoinsCher = livre;
                    prixMinimum = livre.GetPrixLivre();
                }
            }            
            return livreMoinsCher;
        }
    }
}
