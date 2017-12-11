using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe3
{
    class Program
    {
        static void Main(string[] args)
        {
            int alturaRetrato, comprimentoRetrato;
            int alturaMoldura, comprimentoMoldura;

            string[] vetor;

            vetor = Console.ReadLine().Split(' ');
            alturaRetrato = int.Parse(vetor[0]);
            comprimentoRetrato = int.Parse(vetor[1]);

            vetor = Console.ReadLine().Split(' ');
            alturaMoldura = int.Parse(vetor[0]);
            comprimentoMoldura = int.Parse(vetor[1]);

            if ((alturaRetrato <= alturaMoldura && comprimentoRetrato <= comprimentoMoldura) || (alturaMoldura <= comprimentoMoldura && alturaRetrato <= comprimentoMoldura))
            {
                Console.WriteLine("SIM");
            }
            else
            {
                Console.WriteLine("NAO");
            }
            Console.ReadLine();
        }

      
    }
}
