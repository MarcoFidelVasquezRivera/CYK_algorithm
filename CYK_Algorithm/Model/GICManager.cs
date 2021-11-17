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
                Console.Write(gramatic[i, 0]);
            }
            Console.WriteLine();

            IList<IList<string>> productions = new List<IList<string>>();

            for (int i = 0; i < gramatic.GetLength(0); i++)
            {
                IList<string> production = new List<string>();

                for (int j = 1; j < gramatic.GetLength(1); j++)
                {
                    Console.Write(gramatic[i, j]);
                    if (gramatic[i,j]==null)
                    {
                        j = gramatic.GetLength(1);
                    }
                    else
                    {
                        production.Add(gramatic[i, j]);
                    }
                }
                Console.WriteLine();
                productions.Add(production);
            }

            gic.variables = variables;
            gic.productions = productions;
            Console.WriteLine("------------------------------------------------------");
            return gic.CYK(message);
        }
    }
}
