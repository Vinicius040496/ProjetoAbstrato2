using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAbstrato2.Entites
{
    abstract class Contribuinte
    {
        public string Nome { get; set; }
        public double GanhoAnual { get; set; }

        protected Contribuinte()
        {

        }

        protected Contribuinte(string nome, double ganhoAnual)
        {
            Nome = nome;
            GanhoAnual = ganhoAnual;
        }

        public abstract double Imposto();
    }
}
