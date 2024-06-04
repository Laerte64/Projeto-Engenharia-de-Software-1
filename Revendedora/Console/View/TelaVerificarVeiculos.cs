using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    internal class TelaVerificarVeiculos
    {
        public static void ExecutarTela(List<Veiculo> veiculos)
        {
            System.Console.Clear();
            System.Console.WriteLine($"{"ID".PadRight(3)} | {"Marca".PadRight(15)} | {"Modelo".PadRight(15)} | {"Ano".PadRight(4)} | {"Preco".PadRight(10)}");
            System.Console.WriteLine($"{"".PadRight(3)} | {"".PadRight(15)} | {"".PadRight(15)} | {"".PadRight(4)} | {"".PadRight(10)}");
            foreach (var veiculo in veiculos)
                System.Console.WriteLine($"{veiculo.ID.ToString().PadLeft(3)} | {veiculo.Modelo.Marca.PadRight(15)} | {veiculo.Modelo.Nome.PadRight(15)} | {veiculo.Modelo.Ano.ToString().PadLeft(4)} | {"$" + veiculo.Valor.ToString().PadLeft(9)}");
            System.Console.ReadKey();
            System.Console.Clear();
        }
    }
}
