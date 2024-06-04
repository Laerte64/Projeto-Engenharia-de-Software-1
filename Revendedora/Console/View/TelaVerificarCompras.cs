using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Console.View
{
    internal class TelaVerificarCompras
    {
        public static void ExecutarTela(List<Compra> compras)
        {
            System.Console.Clear();
            System.Console.WriteLine($"{"ID".PadRight(3)} | {"Funcionario".PadRight(15)} | {"Fornecedor".PadRight(15)} | {"Marca".PadRight(15)} | {"Modelo".PadRight(15)} | {"Valor".PadRight(10)} ");
            foreach (Compra compra in compras) 
                System.Console.WriteLine($"{compra.ID.ToString().PadLeft(3)} | {compra.Funcionario.Nome.PadRight(15)} | {compra.Fornecedor.Nome.PadRight(15)} | {compra.Veiculo.Modelo.Marca.PadRight(15)} | {compra.Veiculo.Modelo.Nome.PadRight(15)} | {"$" + compra.Valor.ToString().PadLeft(9)}");
            System.Console.ReadKey();
            System.Console.Clear();
        }
    }
}
