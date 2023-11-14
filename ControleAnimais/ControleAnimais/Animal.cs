using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAnimais
{
    internal class Animal
    {
        private string _nome;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value.ToUpper(); }
        }

        private string _tipo;

        public string Tipo
        {
            get { return _tipo; }
            set
            {
                if (value.ToUpper() == "CACHORRO" || value.ToUpper() == "PEIXE" || value.ToUpper() == "GATO")
                {
                    _tipo = value.ToUpper();
                }
                else
                {
                    _tipo = "PEIXE";
                }
            }
        }

    }



}
