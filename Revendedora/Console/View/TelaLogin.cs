using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    internal class TelaLogin
    {
        public static (string login, string senha) ExecutarTela(bool erro = false)
        {
            System.Console.Clear();
            if (erro)
                System.Console.WriteLine("Usuário ou senha Inválidos");
            System.Console.Write("Digite seu Login: ");
            string login = System.Console.ReadLine();
            System.Console.Write("Digite sua Senha: ");
            string senha = Senha.LerSenha();
            System.Console.Clear();
            return (login, senha);
        }
    }
}
