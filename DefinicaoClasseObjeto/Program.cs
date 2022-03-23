using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefinicaoClasseObjeto
{
     //1 -|Defina o que é classe e o que é objeto e como podemos criá-los na lingagem C#
     //   |Podemos definir a classe como um "modelo/template" para criacao de objetos que contem campos, propriedades, eventos e metodos.
     //   |Já o objeto é uma instancia de uma classe.
    internal class Program
    {
        static void Main(string[] args)
        {
            PessoaExercicio1 p1 = new PessoaExercicio1(23);  // Instancia da classe
        }

        public class PessoaExercicio1
        {
            private string nome; 
            public int idade; // Campos 

            public PessoaExercicio1(int idade) // Construtor
            {
                this.idade = idade;
            }
            public string Nome // Propriedade
            {
                get { return nome; }
                set { nome = value; }
            }

            public void Andar() // MEtodo sem retorno.
            {
                Console.WriteLine("Estou andando");
            }
        }
    }
}
