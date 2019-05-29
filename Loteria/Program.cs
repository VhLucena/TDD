using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loteria
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();

            for(int i = 0; i < 129; i++)
            {
                lista.Add(i);
                Console.Write("Capacidade: " + lista.Capacity);
            }

        }
    }
}
