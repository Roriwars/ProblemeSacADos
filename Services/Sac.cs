using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataContracts;

namespace Services
{
    public abstract class Sac
    {
        protected int poidMax;
        public List<Objet> sac { get; set; }

        public Sac()
        {
            poidMax = 15;
            sac = new List<Objet>();
        }

        public Sac(int poid)
        {
            poidMax = poid;
            sac = new List<Objet>();
        }

        public virtual List<Objet> getObjets()
        {
            List<Objet> listeObjets = new List<Objet>();
            Random nbAleat = new Random();
            for (int i = 0; i < 12; i++)
            {
                int poid = nbAleat.Next(2, 14);
                int val = nbAleat.Next(2, 6);
                listeObjets.Add(new Objet() { id = i, nom = "objet" + i, poid = poid, valeur = val });
            }
            return listeObjets;
        }

        public abstract void grosLot(List<Objet> objets);
    }
}
