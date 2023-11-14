using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaFuncionarios
{
    internal class Funcionarios
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public Funcionarios(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void AumentaSalario(int perc)
        {
            Salario += Salario * perc / 100;

        }

        public override string? ToString()
        {
            return $"\n {Id}, {Nome}, {Salario.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
