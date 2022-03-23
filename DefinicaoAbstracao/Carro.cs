using System;

namespace DefinicaoAbstracao
{
    //2/3- A abastracao esta ligada a entidades do mundo real, onde poderemos ou nao abastrair algumas funcionalidades que no contexto em questao podem nao ser necessario mostra-los.
    //    exemplo abaixo, tenho a classe abstrata carro que sera base para qualquer carro criado, nao sendo possivel instanciar a classe carro, apenas herda-la e implementar suas funcionalidades(metodos) 
    abstract class Carro
    {
        public abstract void Ignicao(string ignicao);
        
        public void CalcularConsumo(double kmRodadosPorLitro)
        {
            System.Console.WriteLine($"Seu veiculo faz {Math.Round(100 / kmRodadosPorLitro, 2)} aos 100.");
        }

    }

    class Bmw : Carro
    {
        public override void Ignicao(string ignicao)
        {
            System.Console.WriteLine($"A bmw liga atraves do sistema de {ignicao}");
        }
    } 
    class Dacia : Carro
    {
        public override void Ignicao(string ignicao)
        {
            System.Console.WriteLine($"O Duster Dacia liga atraves do sistema de {ignicao}");
        }
    }
}
