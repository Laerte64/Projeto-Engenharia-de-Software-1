using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    internal class Senha
    {
        public static string LerSenha()
        {
            StringBuilder sb = new StringBuilder();
            while (true)
            {
                ConsoleKeyInfo cki = System.Console.ReadKey(true);
                if (cki.Key == ConsoleKey.Enter)
                {
                    System.Console.WriteLine();
                    break;
                }

                if (cki.Key == ConsoleKey.Backspace)
                {
                    if (sb.Length > 0)
                    {
                        System.Console.Write("\b\0\b");
                        sb.Length--;
                    }

                    continue;
                }

                System.Console.Write('*');
                sb.Append(cki.KeyChar);
            }

            return sb.ToString();
        }
    }
}
