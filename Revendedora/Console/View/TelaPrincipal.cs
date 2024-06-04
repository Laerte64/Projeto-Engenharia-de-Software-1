using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    internal class TelaPrincipal
    {
        public static int ExecutarTela()
        {
            System.Console.Clear();
            System.Console.WriteLine("Opcoes");
            System.Console.WriteLine("1 - Vizualizar Veiculos");
            System.Console.WriteLine("2 - Verificar Vendas");
            System.Console.WriteLine("3 - Verificar Compras");
            System.Console.WriteLine("4 - Verificar Modelos");
            System.Console.WriteLine("5 - Registrar Venda");
            System.Console.WriteLine("6 - Registar Compra");
            System.Console.WriteLine("7 - Registrar Cliente");
            System.Console.WriteLine("8 - Registrar Modelo");
            System.Console.WriteLine("0 - Sair");
            int.TryParse(System.Console.ReadLine(), out int opcao);
            System.Console.Clear();
            return opcao;
        }
    }
}
