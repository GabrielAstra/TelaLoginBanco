using Claz.Dominio;



Console.WriteLine("Digite sua senha:");
int senha = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("DIgite seu login:");
string login = Console.ReadLine();

if (senha == 123 && login == "NomeExemplo")
{
    Console.WriteLine("Tudo certo, acesso liberado a sua conta");

}
else 
{
    Console.WriteLine("Deu errado");
}


Usuario user1 = new Usuario();
user1.Salario = 1200;
user1.Nome = "Exemplo";
user1.Idade = 18;
user1.Apresentar();