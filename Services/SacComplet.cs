using DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class SacComplet : Sac
    {
        private Dictionary<List<Objet>, int> listeSolutions;

        public SacComplet() : base()
        {
            listeSolutions = new Dictionary<List<Objet>, int>();
        }
        public override void grosLot(List<Objet> objets)
        {
            List<Objet> objetAAjouter = new List<Objet>();
            objetAAjouter.Add(objets[0]);
            listeSolutions.Add(objetAAjouter, objets[0].valeur);
            remplissageSac(objets,1);
            int valeurMax = 0;
            List<Objet> meilleurListe = new List<Objet>();
            foreach (KeyValuePair<List<Objet>, int> solution in listeSolutions)
            {
                string affiche = "";
                foreach(Objet objet in solution.Key)
                {
                    affiche += objet.id + " ";
                }
                Console.WriteLine("Clé: {0}, Valeur: {1}",affiche, solution.Value);
                if (solution.Value > valeurMax)
                {
                    valeurMax = solution.Value;
                    meilleurListe = solution.Key;
                }
            }
            sac = meilleurListe;
        }

        private void remplissageSac(List<Objet> objets, int indiceObjet)
        {
            if (objets.Count <= indiceObjet)
            {
                return;
            }
            int tailleListSolution = listeSolutions.Count;
            for (int i = 0; i <tailleListSolution; i++)
            {
                if (!tropLourd(objets[indiceObjet], i))
                {
                    List<Objet> objetAAjouter = new List<Objet>();
                    foreach(Objet objet in listeSolutions.ElementAt(i).Key)
                    {
                        objetAAjouter.Add(objet);
                    }
                    objetAAjouter.Add(objets[indiceObjet]);
                    listeSolutions.Add(objetAAjouter, valeurTotal(objetAAjouter));
                }
            }
            if (objets[indiceObjet].poid < poidMax)
            {
                List<Objet> objetAAjouter = new List<Objet>();
                objetAAjouter.Add(objets[indiceObjet]);
                listeSolutions.Add(objetAAjouter, objets[indiceObjet].valeur);
            }
            indiceObjet++;
            remplissageSac(objets, indiceObjet);
        }

        private bool tropLourd(Objet objet, int indiceDico)
        {
            bool result = false;

            int poidListe = 0;
            for(int i = 0; i < listeSolutions.ElementAt(indiceDico).Key.Count; i++)
            {
                poidListe += listeSolutions.ElementAt(indiceDico).Key[i].poid;
            }
            poidListe += objet.poid;
            if (poidListe > poidMax)
            {
                result = true;
            }

            return result;
        }

        private int valeurTotal(List<Objet> objets)
        {
            int valeur = 0;

            foreach(Objet objet in objets)
            {
                valeur += objet.valeur;
            }

            return valeur;
        }
    }
}
