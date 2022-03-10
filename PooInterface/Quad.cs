using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooInterface
{
    // Interface IDesenhar
    class Quad : IDesenhar
    {
        public float lado;
        public float Area()
        {
            return 4;
        }

        public void Desenhar()
        {
            Console.WriteLine("---- Quadrado ----");
        }
    }
}
