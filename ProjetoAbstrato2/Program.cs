using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoAbstrato2.Entites;

namespace ProjetoAbstrato2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <Contribuinte> lista = new List <Contribuinte>();
            Console.Write("Entre com quantidade de contribuintes: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Contribuinte #{0}",i);
                Console.Write("Contribuinte Fisico Ou Empresa (F/E): ");
                char Resp = char.Parse(Console.ReadLine());

                if (Resp == 'F' || Resp == 'f')
                {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Renda Anual: ");
                    double ganhoAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Despezas com saude: ");
                    double gastoSaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    ContribuinteFisico contribuinteFisico = new ContribuinteFisico(nome, ganhoAnual,gastoSaude);
                    lista.Add(contribuinteFisico);
                    Console.WriteLine();
                } else if 
                    (Resp == 'E' || Resp == 'e')
                {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Renda Anual: ");
                    double ganhoAnual = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    Console.Write("Numero de Funcionarios da empresa: ");
                    int numeroFuncionario = int.Parse(Console.ReadLine());
                    ContribuinteEmpresa contribuinteEmpresa = new ContribuinteEmpresa(nome, ganhoAnual,numeroFuncionario);
                    lista.Add(contribuinteEmpresa);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Entrada invalida,tente novamente!!!");
                }
            }
            Console.WriteLine("Impostos Pagos: ");
            double som = 0;
            foreach (Contribuinte C in lista)
            {
                Console.WriteLine(C.Nome + ": R$ " + C.Imposto().ToString("f2"),CultureInfo.InvariantCulture);
            }
            foreach (Contribuinte C in lista)
            {
                
                som += C.Imposto();

            }
            Console.WriteLine("Total Imposto: " + som.ToString("f2"),CultureInfo.InvariantCulture);
            Console.ReadLine();
    }
    }
}
