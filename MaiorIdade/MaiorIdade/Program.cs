using MaiorIdade;

Pessoa p1;
Pessoa p2;
Pessoa p3;

Console.WriteLine($"Entre com os dados das 3 Pessoas: ");

Console.WriteLine($"\n Nome 1° Pessoa: ");
string nome1 = Console.ReadLine();
Console.WriteLine($"\n Idade 1° Pessoa: ");
int id1 = int.Parse(Console.ReadLine());
p1 = new Pessoa(nome1, id1);

Console.WriteLine($"\n Nome 2° Pessoa: ");
string nome2 = Console.ReadLine();
Console.WriteLine($"\n Idade 2° Pessoa: ");
int id2 = int.Parse(Console.ReadLine());
p2 = new Pessoa(nome2, id2);

Console.WriteLine($"\n Nome 3° Pessoa: ");
string nome3 = Console.ReadLine();
Console.WriteLine($"\n Idade 3° Pessoa: ");
int id3 = int.Parse(Console.ReadLine());
p3 = new Pessoa(nome3, id3);

Pessoa pessoa = new Pessoa();
int resultado = pessoa.MaiorIdade(p1.Idade, p2.Idade, p3.Idade);

if (resultado == p1.Idade)
{
    p1.ExibirDados();
}
else if (resultado == p2.Idade)
{
    p2.ExibirDados();
}
else
    p3.ExibirDados();



