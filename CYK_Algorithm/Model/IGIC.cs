using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CYK_Algorithm.Model
{
    public interface IGIC
    {
        bool CYK(string message);
        IList<string> LookForProducer(string production);
    }
}
