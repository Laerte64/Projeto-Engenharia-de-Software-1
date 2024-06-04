using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    internal class TelaRegistrarVenda
    {
        public static (int id, string cpf, decimal valor) ExecutarTela()
        {
            System.Console.Clear();
            System.Console.Write("Digite o ID do veiculo: ");
            int.TryParse(System.Console.ReadLine(), out int id);
            System.Console.Write("Digite o CPF do cliente: ");
            string cpf = System.Console.ReadLine()!;
            System.Console.Write("Digite o Valor a ser pago: ");
            decimal.TryParse(System.Console.ReadLine(), out decimal valor);
            System.Console.Clear();
            return (id, cpf, valor);
        }

        public static void Sucesso()
        {
            System.Console.Clear();
            System.Console.WriteLine("Venda Cadastrada com Sucesso");
            System.Console.ReadKey();
            System.Console.Clear();
        }

        public static void Erro()
        {
            System.Console.Clear();
            System.Console.WriteLine("Erro ao Cadastrar Venda");
            System.Console.ReadKey();
            System.Console.Clear();
        }
    }
}
