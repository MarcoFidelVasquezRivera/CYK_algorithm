using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CYK_Algorithm.Model
{
    class GICManager
    {
        private GIC gic;

        public GICManager()
        {
            gic = new GIC();
        }

        public bool runCYK(string[,] gramatic, string message)
        {
            IList<string> variables = new List<string>();

            for (int i=0; i< gramatic.GetLength(0);i++)
            {
                variables.Add(gramatic[i,0]);
            }

            IList<IList<string>> productions = new List<IList<string>>();

            for (int i = 0; i < gramatic.GetLength(0); i++)
            {
                IList<string> production = new List<string>();

                for (int j = 0; j < gramatic.GetLength(1); j++)
                {
                    Console.WriteLine(gramatic[i, j].Length);
                    if (gramatic[i,j]==null)
                    {
                        j = gramatic.GetLength(1);
                    }
                    else
                    {
                        production.Add(gramatic[i, j]);
                    }
                }
                productions.Add(production);
            }

            gic.variables = variables;
            gic.productions = productions;
            
            return gic.CYK(message);
        }
    }
}
