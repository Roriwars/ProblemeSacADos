using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataContracts; 

namespace Services
{
    public class SacRapportValPoid : Sac
    {
        private Dictionary<int, double> rapportValeurPoid;

        public SacRapportValPoid() : base()
        {
            rapportValeurPoid = new Dictionary<int, double>();
        }

        public override void grosLot(List<Objet> objets)
        {
            rapportValeurPoid = new Dictionary<int, double>();
            foreach(Objet objet in objets)
            {
                rapportValeurPoid.Add(objet.id,objet.valeur/objet.poid);
            }
            remplissageSac(objets);
        }

        private void remplissageSac(List<Objet> objets)
        {
            if (poidMax > 0)
            {
                if (rapportValeurPoid.Count == 0)
                {
                    foreach (Objet objet in objets)
                    {
                        if (objet.poid <= poidMax)
                        {
                            rapportValeurPoid.Add(objet.id, objet.valeur / objet.poid);
                        }
                    }
                    if (rapportValeurPoid.Count != 0 && poidMax > 0)
                    {
                        remplissageSac(objets);
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    int idObjetRapportMax = plusGrosRapport();
                    if (poidMax >= objets[idObjetRapportMax].poid)
                    {
                        sac.Add(objets[idObjetRapportMax]);
                        Console.WriteLine(poidMax);
                        poidMax -= objets[idObjetRapportMax].poid;
                        Console.WriteLine(poidMax);
                        Console.WriteLine("---");
                    }
                    rapportValeurPoid.Remove(objets[idObjetRapportMax].id);

                    remplissageSac(objets);
                }
            }
        }

        private int plusGrosRapport()
        {
            int result = rapportValeurPoid.ElementAt(0).Key;
            double maxRapport = rapportValeurPoid.ElementAt(0).Value;
            for (int i = 1; i < rapportValeurPoid.Count; i++)
            {
                if (maxRapport.CompareTo(rapportValeurPoid.ElementAt(i).Value)<0)
                {
                    maxRapport = rapportValeurPoid.ElementAt(i).Value;
                    result = rapportValeurPoid.ElementAt(i).Key;
                }
            }
            return result;
        }
    }
}
