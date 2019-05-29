using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loteria
{
    public class Jogo
    {
        public List<Cartela> Cartelas { get; private set; }

        public Jogo()
        {
            Cartelas = new List<Cartela>();
        }


        public void AdicionarCartela(Cartela cartela)
        {
            Cartelas.Add(cartela);
        }
    }
}
