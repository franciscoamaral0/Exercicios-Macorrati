using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtor
{
    //5 - O construtor e chamado sempre que instanciamos uma classe podendo definir valores diferentes a cada criacao, caso seja instanciado 5x, ele sera chamado as 5x.
    internal class Program
    {
        static void Main(string[] args)
        {
            Arquiconsult lisboa = new Arquiconsult("lisboa");
            Arquiconsult porto = new Arquiconsult("Porto");
            Arquiconsult vilaReal = new Arquiconsult("Vila Real");
            Arquiconsult sevilha = new Arquiconsult("Sevilha");
            Arquiconsult barcelona = new Arquiconsult("Barcelona");
        }

        class Arquiconsult
        {
            string sedeAtual;
            public Arquiconsult(string sedeatual)
            {
                this.sedeAtual = sedeatual;
                Console.WriteLine(this.sedeAtual);
            }
        }
    }
}
