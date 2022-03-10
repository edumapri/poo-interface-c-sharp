using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooInterface
{
    // Interface IDesenhar
    class Rect : IDesenhar
    {
        public float Area()
        {
            return 0;
        }

        public void Desenhar()
        {
            Console.WriteLine("---- Rect ----");
        }
    }
    
    
}
