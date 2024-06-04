using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    internal class TelaVerificarModelos
    {
        public static void ExecutarTela(List<Modelo> modelos)
        {
            System.Console.Clear();
            System.Console.WriteLine($"{"ID".PadRight(3)} {"Marca".PadRight(15)} | {"Modelo".PadRight(15)} | {"Ano".PadRight(4)}");
            foreach (var modelo in modelos)
                System.Console.WriteLine($"{modelo.ID.ToString().PadLeft(3)} | {modelo.Marca.PadRight(15)} | {modelo.Nome.PadRight(15)} | {modelo.Ano.ToString().PadLeft(4)}");
            System.Console.ReadKey();
            System.Console.Clear();
        }
    }
}
