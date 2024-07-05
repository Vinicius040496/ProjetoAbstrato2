using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAbstrato2.Entites
{
    internal class ContribuinteFisico: Contribuinte
    {
        public double GastoSaude {  get; set; }

        public ContribuinteFisico()
        {

        }

        public ContribuinteFisico(string nome, double ganhoAnual, double gastoSaude)
            : base(nome,ganhoAnual)
        {
            GastoSaude = gastoSaude;
        }
        public override double Imposto()
        {

            if (GastoSaude <= 20000)
            {
                return GanhoAnual * 0.15 - GastoSaude * 0.50;

            }
            else if (GastoSaude >= 20000)
            {
                return GanhoAnual * 0.25 - GastoSaude * 0.50;
            }
            return Imposto();
        }      
        }
    }

