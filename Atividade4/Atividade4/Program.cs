using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Digite a nome do aluno");
            var aluno = Console.ReadLine();
            Console.WriteLine("Digite a nota 1");
            double nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a nota 2");
            double nota2 = Convert.ToDouble(Console.ReadLine());

            double mediaNota = (nota1 + nota2) / 2;
            */

            // -----------------------------------------------------------------------------------------------------------

            /*
            if (mediaNota >= 6)
            {
                Console.WriteLine("O aluno " + aluno + " foi (Aprovado) com média " + mediaNota);
            } 
            else
            {
                Console.WriteLine("O aluno " + aluno + " foi (Reprovado) com média " + mediaNota);
            }
            */

            // -----------------------------------------------------------------------------------------------------------

            /*
            if (mediaNota == 0)
            {
                Console.WriteLine("Você não aprendeu nada. (Reprovado) com média " + mediaNota);
            }
            else if (mediaNota > 0 && mediaNota <= 4)                
            {
                Console.WriteLine("Você está (Reprovado) com média " + mediaNota);
            }
            else if (mediaNota >= 5 && mediaNota <= 7)
            {
                Console.WriteLine("Você passou raspando. (Reprovado) com média " + mediaNota);
            }
            else if (mediaNota >= 8 && mediaNota <= 9)
            {
                Console.WriteLine("Você mandou bem. (Aprovado) com média " + mediaNota);
            }
            else if (mediaNota >= 9 && mediaNota < 10)
            {
                Console.WriteLine("Boa!!! Show. Você foi (Aprovado) com média " + mediaNota);
            }
            else 
            {
                Console.WriteLine("Parabéns!!! você é muito inteligente. (Aprovado) com média " + mediaNota);
            }
            */

            // -----------------------------------------------------------------------------------------------------------

            /*
             avaliar o switch [é preferível ao if]
            */



            Console.WriteLine("Digite um numero multiplicador para a taboada:");
            int numTab = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n Resultado----");


            int n = 1;
            while (n <= 10)
            {
                Console.WriteLine(n + " * " + numTab + " = " + numTab*n);
                n++;
            }


            Console.ReadKey();
        }
    }
}

