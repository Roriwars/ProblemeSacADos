using DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public class SacDynamique :Sac
    {
        private int[,] solutions;
        private List<int>[] solutionsBis;

        public SacDynamique():base()
        {
        }
        public SacDynamique(List<Objet> objets) : base()
        {
            solutions = new int[objets.Count(), poidMax + 1];
            solutionsBis = new List<int>[poidMax + 1];
            for (int i = 0; i < poidMax + 1; i++)
            {
                solutionsBis[i] = new List<int>();
            }
        }

        public override void grosLot(List<Objet> objets)
        {
            for (int w = 0; w < poidMax + 1; w++)
            {
                if (w < objets[0].poid)
                {
                    solutions[0, w] = 0;
                }
                else
                {
                    solutions[0, w] = objets[0].valeur; 
                    solutionsBis[w].Add(0);
                }
            }
            for (int c = 0; c < objets.Count(); c++)
            {
                solutions[c, 0] = 0;
            }
            for (int i = 1; i < objets.Count(); i++)
            {
                for (int w = 0; w < poidMax + 1; w++)
                {
                    if (w >= objets[i].poid)
                    {
                        if (solutions[i - 1, w] < solutions[i - 1, w - objets[i].poid] + objets[i].valeur)
                        {
                            solutions[i, w] = solutions[i - 1, w - objets[i].poid] + objets[i].valeur;
                            solutionsBis[w].Add(i);
                        }
                        else
                        {
                            solutions[i, w] = solutions[i - 1, w];
                        }
                    }
                    else
                    {
                        solutions[i, w] = solutions[i - 1, w];
                    }
                }
            }
            for (int x = 0; x < solutions.GetLength(0); x++) {
                string result = "";
                for (int y = 0; y < solutions.GetLength(1); y++)
                {
                    result += solutions[x, y] + ";";
                }
                Console.WriteLine(result);
            }
            Console.WriteLine("-------");
            Console.WriteLine("Valeur max : "+solutions[objets.Count()-1, poidMax]);
            int poid = poidMax;
            int valMax = 0;
            while (poid>0 && solutionsBis[poid].Count()!=0)
            {
                int indice = solutionsBis[poid][solutionsBis[poid].Count() - 1];
                sac.Add(objets[indice]);
                valMax += objets[solutionsBis[poid][solutionsBis[poid].Count() - 1]].valeur;
                poid -= objets[solutionsBis[poid][solutionsBis[poid].Count() - 1]].poid;
                for(int i = 0; i < poidMax+1; i++)
                {
                    for(int j = indice; j < objets.Count(); j++)
                    {
                        solutionsBis[i].Remove(j);
                    }
                }
            }
            Console.WriteLine(valMax);
        }

    }
}