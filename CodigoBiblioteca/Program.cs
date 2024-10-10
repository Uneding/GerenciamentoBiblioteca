class Program
{
    public class Login
{
    public string usuario {get; set;}
    public string senha {get; set;}
}
    

    static void Main()
    {
        List<Login> ListaLogin = new List<Login>();
        bool pls = false;
    do
    {
        Login posicao = new Login();
        posicao.usuario = Console.ReadLine();
        posicao.senha = Console.ReadLine();
        ListaLogin.Add(posicao);
        if (posicao.usuario=="sair")
        {
            pls = true;
        }
    }while(pls == false);
        foreach(Login posicao in ListaLogin){
       Console.WriteLine(posicao.usuario);
        }       
    }
}