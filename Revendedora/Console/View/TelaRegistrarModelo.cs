using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    internal class TelaRegistrarModelo
    {
        public static void ExecutarTela()
        {
            System.Console.Clear();
        }

        public static string PerguntarNome()
        {
            System.Console.Write("Digite o nome do modelo: ");
            return System.Console.ReadLine()!;
        }

        public static string PerguntarMarca()
        {
            System.Console.Write("Digite a marca do modelo: ");
            return System.Console.ReadLine()!;

        }

        public static int PerguntarAno()
        {
            System.Console.Write("Digite o ano do modelo: ");
            int.TryParse(System.Console.ReadLine()!, out int ano);
            return ano;
        }

        public static string PerguntarMotor()
        {
            System.Console.Write("Digite o motor do modelo: ");
            return System.Console.ReadLine()!;
        }

        public static int PerguntarNumPortas()
        {
            System.Console.Write("Digite o numero de portas do modelo: ");
            int.TryParse(System.Console.ReadLine()!, out int numP);
            return numP;
        }

        public static string PerguntarTransmissao()
        {
            System.Console.Write("Digite a transmissao do modelo: ");
            return System.Console.ReadLine()!;
        }

        public static string PerguntarCombustivel()
        {
            System.Console.Write("Digite o combustivel do modelo: ");
            return System.Console.ReadLine()!;
        }
    }
}
