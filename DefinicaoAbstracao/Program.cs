using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefinicaoAbstracao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bmw m3 = new Bmw();
            m3.Ignicao("Start Stop");
            m3.CalcularConsumo(7);

            //------

            Dacia duster = new Dacia();
            duster.Ignicao("Chave");
            duster.CalcularConsumo(20);
            

            Console.ReadLine();
        }
    }
}
