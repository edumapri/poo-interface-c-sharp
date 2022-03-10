using PooInterface; // para herança
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooInterface
{
    class Programa
    {
        static void Main(string[] args)
        {
            // Ine, Quad, Rect, Tri, Circ
            IDesenhar forma = new Quad();
            // só consiguimos acessar os métodos
            forma.Desenhar();

            Console.ReadLine();
        }
    }
    interface IDesenhar
    {
        void Desenhar();
        float Area();
    }
}
