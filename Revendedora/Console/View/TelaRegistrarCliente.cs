using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    internal class TelaRegistrarCliente
    {
        public static (string nome, string cpf) ExecutarTela()
        {
            System.Console.Clear();
            System.Console.Write("Digite o nome do cliente: ");
            string nome = System.Console.ReadLine()!;
            System.Console.Write("Digite o CPF do cliente: ");
            string cpf = System.Console.ReadLine()!;
            System.Console.Clear();
            return (nome, cpf);
        }

        public static void Sucesso()
        {
            System.Console.Clear();
            System.Console.WriteLine("Cliente Cadastrada com Sucesso");
            System.Console.ReadKey();
            System.Console.Clear();
        }

        public static void Erro()
        {
            System.Console.Clear();
            System.Console.WriteLine("Erro ao Cadastrar Cliente");
            System.Console.ReadKey();
            System.Console.Clear();
        }
    }
}
