using ControleAnimais;

Animal an1 = new Animal();
Animal an2 = new Animal();
Animal an3 = new Animal();
Animal an4 = new Animal();
Animal an5 = new Animal();

Console.WriteLine($"\n -- Controle de Animais --");

Console.WriteLine($"\nInforme o Nome do 1° Animal: ");
an1.Nome = (Console.ReadLine());
Console.WriteLine($"\nInforme o Tipo do 1° Animal: ");
an1.Tipo = (Console.ReadLine());

Console.WriteLine($"\nInforme o Nome do 2° Animal: ");
an2.Nome = (Console.ReadLine());
Console.WriteLine($"\nInforme o Tipo do 2° Animal: ");
an2.Tipo = (Console.ReadLine());

Console.WriteLine($"\nInforme o Nome do 3° Animal: ");
an3.Nome = (Console.ReadLine());
Console.WriteLine($"\nInforme o Tipo do 3° Animal: ");
an3.Tipo = (Console.ReadLine());

Console.WriteLine($"\nInforme o Nome do 4° Animal: ");
an4.Nome = (Console.ReadLine());
Console.WriteLine($"\nInforme o Tipo do 4° Animal: ");
an4.Tipo = (Console.ReadLine());

Console.WriteLine($"\nInforme o Nome do 5° Animal: ");
an5.Nome = (Console.ReadLine());
Console.WriteLine($"\nInforme o Tipo do 5° Animal: ");
an5.Tipo = (Console.ReadLine());

int contC = 0, contG = 0, contP = 0;

if (an1.Tipo == "CACHORRO") contC++;
if (an1.Tipo == "GATO") contG++;
if (an1.Tipo == "PEIXE") contP++;

if (an2.Tipo == "CACHORRO") contC++;
if (an2.Tipo == "GATO") contG++;
if (an2.Tipo == "PEIXE") contP++;

if (an3.Tipo == "CACHORRO") contC++;
if (an3.Tipo == "GATO") contG++;
if (an3.Tipo == "PEIXE") contP++;

if (an4.Tipo == "CACHORRO") contC++;
if (an4.Tipo == "GATO") contG++;
if (an4.Tipo == "PEIXE") contP++;

if (an5.Tipo == "CACHORRO") contC++;
if (an5.Tipo == "GATO") contG++;
if (an5.Tipo == "PEIXE") contP++;


Console.WriteLine("\n Relatorio ---");
Console.WriteLine($"\n Cachorro: {contC}\n Peixe: {contP}\n Gato: {contG}");
