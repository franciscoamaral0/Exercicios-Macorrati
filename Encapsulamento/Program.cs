using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    //4 - Vantagem do encapsulamento e literalmente encapsular uma propriedade, nao permitindo a criacao sem por exemplo validarmos os campos.
    internal class Program
    {
        static void Main(string[] args)
        {
            LivrariaLelo cliente1 = new LivrariaLelo("Francisco Amaral", "harry potter", 12);
            
        }
        class LivrariaLelo
        {
            public string NomeCliente { get; private set; }
            public string ProdutoComprado { get; private set; }
            public double ValorProduto { get; private set; }

            public LivrariaLelo(string nomecliente, string produtocomprado, double valordoproduto)
            {
                if (string.IsNullOrEmpty(nomecliente) || string.IsNullOrEmpty(produtocomprado))
                {
                    throw new InvalidOperationException("Por favor verifico se o nome ou produto foi corretamente inserido.");
                }
                if(valordoproduto < 0)
                    throw new InvalidOperationException("Valor do produto invalido.");

                this.NomeCliente = nomecliente;
                this.ProdutoComprado = produtocomprado; 
                this.ValorProduto = valordoproduto;
            }
        }
    }
}
