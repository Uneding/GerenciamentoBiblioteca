using System.Security.Cryptography.X509Certificates;
using System;
using System.Collections.Generic;
class Program
{
    static List<Login> ListaLogin = new List<Login>();
      static void login(string x, string y)
    {
        Login posicao = new Login();
        posicao.usuario = x;
        posicao.senha = y;
        ListaLogin.Add(posicao);
        
    }
    public class Login
    {
        public string usuario { get; set; }
        public string senha { get; set; }
                public override string ToString()
        {
            return $"Usuário: {usuario}, Senha: {senha}\n";
        }
    }
    static void Main()
    {
        for(int i =0; i<4;i++)
        {
        login(Console.ReadLine(), Console.ReadLine());
        }
        for(int i =0; i<4;i++)
        {
        Console.WriteLine(ListaLogin[i]);
        }

    }
  
}