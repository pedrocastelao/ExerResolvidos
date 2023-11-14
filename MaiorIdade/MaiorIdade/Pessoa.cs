using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MaiorIdade
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa()
        {
        }

        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public int MaiorIdade(int id1, int id2, int id3)
        {
            if (id1 > id2 && id1 > id3)
            {
                return id1;
            }
            else if (id2 > id3)
            {
                return id2;
            }
            else
                return id3;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"\n Nome: {this.Nome}, Idade: {this.Idade}");
        }
    }
}
