using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargaMetodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Somar teste = new Somar();
            teste.Soma(4,6);
        }
        
        class Somar
        {
            public int Soma(int a, int b)
            {
                return a + b;
            }
            public double Soma(double a, double b)
            {
                return a - b;
            }
            public double Soma(int a)
            {
                double resultado;
                
                if (a == 1)
                    return 1;
                else
                    resultado = a * Soma(a - 1);
                Console.WriteLine(resultado);
                    return a * Soma(a - 1);
                
            }
            public string Soma()
            {
                return "Nao foi passado nenhum valor";
            }

        }

        class ValoresPadrao
        {
            public int Atribuicao(int total=0, int num1=4, int num2=, int num3=10)
            {
                return total += num1 + num2 + num3;
            }
        }
    }
}


