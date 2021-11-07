using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CYK_Algorithm.Model
{
    public class GIC : IGIC
    {
        private IList<string> variables;
        private IList<IList<string>> productions;

        public GIC(IList<String> variables, IList<IList<string>> productions)
        {
            this.variables = variables;
            this.productions = productions;
        }

        public bool CYK()
        {
            throw new NotImplementedException();
        }
    }
}
