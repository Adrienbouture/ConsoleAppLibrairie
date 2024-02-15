using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;

namespace ConsoleAppLibrairie
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Librairie uneLibrairie = new Librairie("Martelle", "3 Rue des Vergeaux", 80000, "Amiens", "martelle@gmail.com", 0303030303);
            Livre unLivre = new Livre(1, " L'appel de Cthulhu", "H.P.Lovecraft", 5.45, 12);
           
            uneLibrairie.AjouterLivre(unLivre);

            int option = 0;
           
                do
                {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Choisir une option");
                    Console.WriteLine("1<-- Rechercher un livre par numéro");
                    Console.WriteLine("2<-- Ajouter un nouveau livre dans la librairie");
                    Console.WriteLine("3<-- Supprimer un livre de la librairie");
                    Console.WriteLine("4<-- Modifier un livre");
                    Console.WriteLine("5<-- Approvisionner le stock d’un livre");
                    Console.WriteLine("6<-- Vendre un nombre d’exemplaires d’un livre");
                    Console.WriteLine("7<-- Afficher tous les livres");
                    Console.WriteLine("8<-- Afficher le livre le moins cher");
                    Console.WriteLine("0<-- Quitter");
                    option = int.Parse(Console.ReadLine());
                    int cpt = uneLibrairie.GetLivres().Cardinal();

                    if (option == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Recherche d'un livre par numéro");
                        Console.WriteLine("Saisir un numéro");
                        int numero = int.Parse(Console.ReadLine());

                        bool livreTrouve = false;

                        foreach (Livre livre in uneLibrairie.GetLivres().GetCollection())
                        {
                            if (livre.GetNumLivre() == numero)
                            {
                                Console.WriteLine("Livre trouvé : ");
                                livre.Afficher();
                                livreTrouve = true;
                                Console.ReadKey();
                            }
                        }
                        if (livreTrouve == false)
                        {
                            Console.WriteLine("Erreur : il n'existe pas de livre avec le numéro {0}", numero);
                            Console.ReadKey();
                        }
                    }

                    if (option == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("Ajout d'un livre dans la librairie");
                        Console.WriteLine();
                        Console.WriteLine("Titre du Livre :");
                        string titre = Console.ReadLine();
                        Console.WriteLine("Auteur du livre :");
                        string auteur = Console.ReadLine();
                        Console.WriteLine("Prix du livre :");
                        double prix = int.Parse(Console.ReadLine());
                        Console.WriteLine("Stock du livre :");
                        int stock = int.Parse(Console.ReadLine());
                        Livre newLivre = new Livre(cpt + 1, titre, auteur, prix, stock);
                        uneLibrairie.AjouterLivre(newLivre);
                        Console.WriteLine("Le livre a été ajouté");
                        Console.ReadKey();
                    }

                    if (option == 3)
                    {
                        Console.Clear();
                        Console.WriteLine("Suppression d'un livre dans la librairie");
                        Console.WriteLine();
                        Console.WriteLine("Numero du livre a supprimer : ");
                        int numero = int.Parse(Console.ReadLine());
                        bool livreTrouve = false;

                        foreach (Livre livre in uneLibrairie.GetLivres().GetCollection())
                        {
                            if (livre.GetNumLivre() == numero)
                            {
                                uneLibrairie.SupprimerLivre(numero);
                                livreTrouve = true;
                                Console.WriteLine("Le livre a été supprimé");
                                Console.ReadKey();
                            }
                        }
                        if (livreTrouve == false)
                        {
                            Console.WriteLine("Livre introuvable");
                            Console.ReadKey();
                        }
                        Console.ReadKey();
                    }

                    if (option == 4)
                    {
                        Console.Clear();
                        Console.WriteLine("Modification d'un livre");
                        Console.WriteLine("Numero du livre a modifier : ");
                        int numero = int.Parse(Console.ReadLine());
                        bool livreTrouve = false;

                        foreach (Livre livre in uneLibrairie.GetLivres().GetCollection())
                        {
                            if (livre.GetNumLivre() == numero)
                            {
                                livreTrouve = true;
                                Console.WriteLine("Titre du livre : ");
                                string nouveauTitre = Console.ReadLine();
                                Console.WriteLine("Auteur du livre : ");
                                string nouvelAuteur = Console.ReadLine();
                                Console.WriteLine("Prix du livre : ");
                                double nouveauPrix = double.Parse(Console.ReadLine());
                                Console.WriteLine("Stock du livre : ");
                                int nouveauStock = int.Parse(Console.ReadLine());

                                livre.SetTitreLivre(nouveauTitre);
                                livre.SetAuteurLivre(nouvelAuteur);
                                livre.SetPrixLivre(nouveauPrix);
                                livre.SetStockLivre(nouveauStock);
                                Console.WriteLine("Le livre a été modifié");
                                Console.ReadKey();
                            }
                        }
                        if (livreTrouve == false)
                        {
                            Console.WriteLine("Livre introuvable");
                            Console.ReadKey();
                        }
                        Console.ReadKey();
                    }

                    if (option == 5)
                    {
                        Console.Clear();
                        Console.WriteLine("Approvisionnement du stock d'un livre");
                        Console.WriteLine("Numero du livre a approvisionner : ");
                        int numero = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nombre de livre a ajouter au stock : ");
                        int quantite = int.Parse(Console.ReadLine());
                        bool livreTrouve = false;

                        foreach (Livre livre in uneLibrairie.GetLivres().GetCollection())
                        {
                            if (livre.GetNumLivre() == numero)
                            {
                                unLivre.Approvisionner(quantite);
                                livreTrouve = true;
                                Console.WriteLine("Le stock a été mis a jour");
                                Console.ReadKey();
                            }
                        }
                        if (livreTrouve == false)
                        {
                            Console.WriteLine("Livre introuvable");
                            Console.ReadKey();
                        }
                    }

                    if (option == 6)
                    {
                        Console.Clear();
                        Console.WriteLine("Vente d'un livre");
                        Console.WriteLine("Numero du livre a vendre : ");
                        int numero = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nombre de livre a vendre : ");
                        int quantite = int.Parse(Console.ReadLine());
                        bool livreTrouve = false;

                        foreach (Livre livre in uneLibrairie.GetLivres().GetCollection())
                        {
                            if (livre.GetNumLivre() == numero)
                            {
                                unLivre.Vendre(quantite);
                                livreTrouve = true;
                                Console.WriteLine("Le stock a été mis a jour");
                                Console.ReadKey();
                            }
                        }
                        if (livreTrouve == false)
                        {
                            Console.WriteLine("Livre introuvable");
                            Console.ReadKey();
                        }
                    }

                    if (option == 7)
                    {
                        Console.Clear();
                        Console.WriteLine("Liste des livres");
                        uneLibrairie.AfficherLivres();
                        Console.WriteLine();
                        Console.ReadKey();
                    }

                    if (option == 8)
                    {
                        Console.Clear();
                        Console.WriteLine("Livre le moins cher : ");
                        uneLibrairie.MoinsCher();
                        Console.ReadKey();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }

                } while (option != 0) ;
            



        }
    }
}
