using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAbstrato2.Entites
{
    internal class ContribuinteEmpresa : Contribuinte
    {
        public int NumeroFuncionario { get; set; }

        public ContribuinteEmpresa()
        {

        }

        public ContribuinteEmpresa(string nome, double ganhoAnual, int numeroFuncionario)
            : base(nome,ganhoAnual)
        {
            NumeroFuncionario = numeroFuncionario;
        }

        public override double Imposto()
        {
          
           if (NumeroFuncionario <= 10)
            {
                return (GanhoAnual * 0.16);
            }
            else
            {
                return (GanhoAnual * 0.14);
            }
           
        }
    }
}
