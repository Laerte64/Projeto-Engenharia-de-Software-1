using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    internal class TelaVerificarVendas
    {
        public static void ExecutarTela(List<Venda> vendas)
        {
            System.Console.Clear();
            System.Console.WriteLine($"{"ID".PadRight(3)} | {"Funcionario".PadRight(15)} | {"Cliente".PadRight(15)} | {"Marca".PadRight(15)} | {"Modelo".PadRight(15)} | {"Valor".PadRight(10)} ");
            foreach (var venda in vendas)
                System.Console.WriteLine($"{venda.ID.ToString().PadLeft(3)} | {venda.Funcionario.Nome.PadRight(15)} | {venda.Cliente.Nome.PadRight(15)} | {venda.Veiculo.Modelo.Marca.PadRight(15)} | {venda.Veiculo.Modelo.Nome.PadRight(15)} | {"$" + venda.Valor.ToString().PadLeft(9)}");
            System.Console.ReadKey();
            System.Console.Clear();
        }
    }
}
