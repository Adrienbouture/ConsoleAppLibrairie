using System;

namespace ConsoleAppLibrairie
{
    public class Livre
    {
        private int numLivre;
        private string titreLivre;
        private string auteurLivre;
        private double prixLivre;
        private int stockLivre;

        public Livre(int numero, string titre, string auteur, double prix, int stock)
        {
            numLivre = numero;
            titreLivre = titre;
            auteurLivre = auteur;
            prixLivre = prix;
            stockLivre = stock;
        }

        public int GetNumLivre()
        {
            return numLivre;
        }

        public void SetNumLivre(int num)
        {
            numLivre = num;
        }
        public string GetTitreLivre()
        {
            return titreLivre;
        }
        public void SetTitreLivre(string titre)
        {
            titreLivre = titre;
        }
        public string GetAuteurLivre()
        {
            return auteurLivre;
        }
        public void SetAuteurLivre(string auteur)
        {
            auteurLivre = auteur;
        }
        public double GetPrixLivre()
        {
            return prixLivre;
        }

        public void SetPrixLivre(double prix)
        {
            prixLivre = prix;
        }

        public int GetStockLivre()
        {
            return stockLivre;
        }
        public void SetStockLivre(int quantite)
        {
            stockLivre = quantite;
        }

        public void Approvisionner(int quantite)
        {
            stockLivre = stockLivre + quantite;
        }
        public void Vendre(int quantite)
        {
            if(quantite <= stockLivre)
            {
                stockLivre = stockLivre - quantite;
            }
            else
            {
                Console.WriteLine("Stock insuffisant. Stock disponible : {0}" , stockLivre);
            }
        } 
        public void Afficher()
        {
            Console.WriteLine("Numéro du livre {0} ",GetNumLivre());
            Console.WriteLine("Titre du livre : {0} ",GetTitreLivre());
            Console.WriteLine("Auteur du livre : {0}",GetAuteurLivre());
            Console.WriteLine("Prix du livre : {0} euros",GetPrixLivre());
            Console.WriteLine("Stock du livre : {0}",GetStockLivre());
        }
    }
}
