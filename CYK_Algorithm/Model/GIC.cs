using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CYK_Algorithm.Model
{
    public class GIC : IGIC
    {
        public IList<string> variables { get; set; }
        public IList<IList<string>> productions { get; set; }

        public GIC()
        {

        }

        public GIC(IList<string> variables, IList<IList<string>> productions)
        {
            this.variables = variables;
            this.productions = productions;
        }

        public bool CYK(string message)
        {
            if (message.Equals(""))//in case the given chain is empty
            {
                if (productions[0].Contains("%"))
                {
                    return true;
                }
                return false;
            }

            List<string>[,] cykTable = new List<string>[message.Length,message.Length];

            //INICIALIZACIÓN
            for (int i=0;i< cykTable.GetLength(0);i++)
            {
                IList<string> producers = LookForProducer(message.Substring(i,1));

                cykTable[i, 0] = new List<string>();
                cykTable[i, 0].AddRange(producers);
            }

            //REPETICIÓN DEL ALGORITMO GENERAL
            for (int j = 1; j< cykTable.GetLength(1); j++)
            {
                for (int i = 0; i < (cykTable.GetLength(0)-j) ; i++)
                {
                    List<string> producerVariables = new List<string>();//todas la variables que me pueden producir Xij

                    for (int k = 0; k <= j-1 ; k++)
                    {
                        /*foreach (string element in cykTable[i + k+1, j-k])
                        {
                            Console.Write(element);
                        }
                        Console.WriteLine("-----------------------++++++++++++++++++");*/

                        List<string> xik = new List<string>(cykTable[i, k]);
                        List<string> xikjk = new List<string>(cykTable[i+k+1, j-(k+1)]);//obtengo Xik y Xi+k,j−k

                        //realizo la union entre Xik y Xi+k,j−k
                        List<string> union = new List<string>();

                        if (xik.Count > 0 && xikjk.Count > 0)
                        {
                            foreach (string element in xik)
                            {
                                foreach (string item in xikjk)
                                {
                                    union.Add(element + item);
                                }
                            }
                        }
                        else if (xik.Count > 0)
                        {

                            foreach (string element in xik)
                            {
                                union.Add(element);
                            }
                        }
                        else {
                            foreach (string item in xikjk)
                            {
                                union.Add(item);
                            }
                        }

                        foreach (string element in union)//agrego las variables productoras de cada elemento
                        {
                            producerVariables.AddRange(LookForProducer(element));
                        }

                    }
                    producerVariables = producerVariables.Distinct().ToList();//elimino las variables redundantes
                    cykTable[i, j] = producerVariables;
                }
            }

            int maximumColumn = cykTable.GetLength(1);

            foreach (string element in cykTable[0, maximumColumn-1])
            {
                if (element.Equals(variables[0]))
                {
                    return true;
                }
            }

            return false;
        }

        //this method gets a production, tries to find the variables that produce it and return a List with all of them
        public IList<string> LookForProducer(string production)
        {//busca en todas las producciones de cada variable para ver si production está entre una de ellas
            
            IList<string> producers = new List<string>();
            for (int i = 0; i<productions.Count; i++)
            { 
                IList<string> currentProductions = productions[i]; // producciones de la variable actual
                for (int j = 0; j < currentProductions.Count; j++)
                {
                    string currentProduction = currentProductions[j];
                    if (currentProduction.Equals(production))
                    {//se compara si son iguales y si lo son se añade a la variable y a las productoras 
                        producers.Add(variables[i]);
                    }
                    
                }
            }
            return producers;
        }
    }
}
