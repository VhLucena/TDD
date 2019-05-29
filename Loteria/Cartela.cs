using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loteria
{
    public class Cartela
    {
        public List<int> Numeros { get; private set; }

        public Cartela(int n1, int n2, int n3, int n4, int n5, int n6)
        {
            Numeros = new List<int>() { n1, n2, n3, n4, n5, n6 };
        }
    }
}
