namespace PileV3
{
    /// <summary>
    /// Pile contenant pouvant coutenir des entiers. 
    /// On ajoute après le dernier élement ajouté 
    /// On retire toujours le dernier élément ajouté 
    /// </summary>
    class Pile
    {
        /// <summary>
        /// Nombre maximum d'éléments de la Pile
        /// </summary>
        private int nBmaxELT;

        /// <summary>
        /// Liste contenant les éléments de la pile
        /// </summary>
        private System.Collections.Generic.List<int> elements;

        public Pile(int nBmaxELT, List<int> elements)
        {
            this.nBmaxELT = nBmaxELT;
        }

        /// <summary>
        /// Initialise la pile avec un nombre nbMaxElt.
        /// </summary>
        /// <param name="nbMaxElt"></param>
        public Pile(int nbMaxElt)
        {
            this.nBmaxELT = nbMaxElt;
            this.elements = new List<int>();
        }

        static bool EstVide(Pile unePile)
        {
            return unePile.elements.Count == 0;
        }

        static bool EstPleine(Pile unePile)
        {
            return unePile.elements.Count == unePile.nBmaxELT;
        }

        static void Empiler(ref Pile unePile, Object obj)
        {
            if (EstPleine(unePile))
            {
                throw new Exception($"Pile pleine, impossible d'empiler l'élément \"{obj}\"");
            }
            else
            {
                unePile.elements.Add((int)obj);
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}