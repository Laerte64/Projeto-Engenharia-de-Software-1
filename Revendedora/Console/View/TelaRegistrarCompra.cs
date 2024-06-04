using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    internal class TelaRegistrarCompra
    {
        public static (int idModelo, string cnpj, decimal valor, int idEstabelecimento) ExecutarTela()
        {
            System.Console.Clear();
            System.Console.Write("Digite o ID do mdodelo: ");
            int.TryParse(System.Console.ReadLine(), out int idModelo);
            System.Console.Write("Digite o CNPJ do fornecedor: ");
            string cnpj = System.Console.ReadLine()!;
            System.Console.Write("Digite o Valor a ser pago: ");
            decimal.TryParse(System.Console.ReadLine(), out decimal valor);
            System.Console.Write("Digite o ID do Estabelecimento: ");
            int.TryParse(System.Console.ReadLine(), out int idEstabelecimento);
            System.Console.Clear();
            return (idModelo, cnpj, valor, idEstabelecimento);
        }

        public static void Sucesso()
        {
            System.Console.Clear();
            System.Console.WriteLine("Compra Cadastrada com Sucesso");
            System.Console.ReadKey();
            System.Console.Clear();
        }

        public static void Erro()
        {
            System.Console.Clear();
            System.Console.WriteLine("Erro ao Cadastrar Compra");
            System.Console.ReadKey();
            System.Console.Clear();
        }
    }
}
