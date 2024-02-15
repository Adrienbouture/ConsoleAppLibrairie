using System;
using System.Collections.Generic;

namespace ConsoleAppLibrairie
{
    public class Collection
    {
        private List<Object> maCollection;

        public Collection()
        {
            maCollection = new List<Object>();
        }
        public void AjouterObjet(object unLivre)
        {
            maCollection.Add(unLivre);
        }
        public void SupprimerObjetIndex(int numIndex)
        {
            if (numIndex > 0 && maCollection.Count > numIndex)
            {
                maCollection.RemoveAt(numIndex);
            }
            else
            {
                Console.WriteLine("Index hors des limites de la collection");
            }
        }
        public List<Object> GetCollection()
        {
            return maCollection;
        }
        public int Cardinal()
        {
            return maCollection.Count;
        }

    }
}
