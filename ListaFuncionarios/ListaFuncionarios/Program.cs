using ListaFuncionarios;
using System.Threading.Channels;

Console.WriteLine($"\n Quantos Funcionarios seram registrado ?");
int n = int.Parse(Console.ReadLine());

List<Funcionarios> list = new List<Funcionarios>();

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"\n");
    Console.WriteLine($"Funcionario #{i}:");

    Console.WriteLine("Id: ");
    int id = int.Parse(Console.ReadLine());
    Console.WriteLine("Nome: ");
    string nome = Console.ReadLine();
    Console.WriteLine("Salario: ");
    double salario = int.Parse(Console.ReadLine());


    list.Add(new Funcionarios(id, nome, salario));
}

Console.WriteLine($"\n Qual ID deseja aumentar o Salario ?");
int auxId = int.Parse(Console.ReadLine());

Funcionarios func = list.Find(x => x.Id == auxId);

if (func != null)
{
    Console.WriteLine($"\n Quantos porcento quer aumentar ?");
    int porcento = int.Parse(Console.ReadLine());
    func.AumentaSalario(porcento);
}
else
{
    Console.WriteLine($"\n Nao tem este ID");
}


foreach (Funcionarios obj in list)
{
    Console.WriteLine(obj);
}
