using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class GuiaHibrida : Guia
    {
        public override void Mostrar()
        {
            Console.WriteLine("Guia Modalidad Híbrida(semipresencial");
        }
    }
}
