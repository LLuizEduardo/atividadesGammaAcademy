using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAula1
{
    class Program
    {
        static void Main(string[] args)
        {
            // for( int a = 1; a < 3; a++)
            // {
            //      Console.WriteLine("Digite o nome do aluno " + a + " e suas 3 notas");
            //     var NomeAluno = Console.ReadLine();
            //    double Nota1 = Console.ReadLine();
            //    double Nota2 = Console.ReadLine();
            //    double Nota3 = Console.ReadLine();
            //  }

            string sec = ("---------------------------------------------------------------");

            Console.WriteLine("Digite a nome do aluno 1");
            var Aluno1 = Console.ReadLine();
            Console.WriteLine("Digite a nota 1");
            double Nota11 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a nota 2");
            double Nota21 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a nota 3");
            double Nota31 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(sec);

            Console.WriteLine("Digite a nome do aluno 2");
            var Aluno2 = Console.ReadLine();
            Console.WriteLine("Digite a nota 1");
            double Nota12 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a nota 2");
            double Nota22 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a nota 3");
            double Nota32 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(sec);
            
            Console.WriteLine("Digite a nome do aluno 3");
            var Aluno3 = Console.ReadLine();
            Console.WriteLine("Digite a nota 1");
            double Nota13 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a nota 2");
            double Nota23 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a nota 3");
            double Nota33 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(sec);

            double MediaNota1 = (Nota11 + Nota21 + Nota31) / 3;
            double MediaNota2 = (Nota12 + Nota22 + Nota32) / 3;
            double MediaNota3 = (Nota13 + Nota23 + Nota33) / 3;

            Console.WriteLine("-----------------------Resultados------------------------------");
            Console.WriteLine("A média de " + Aluno1 + " é " + MediaNota1);
            Console.WriteLine("A média de " + Aluno2 + " é " + MediaNota2);
            Console.WriteLine("A média de " + Aluno3 + " é " + MediaNota3);

            Console.WriteLine("-----------------------Maior Média-----------------------------");
            if ( MediaNota1 > MediaNota2 && MediaNota1 > MediaNota3)
            { Console.WriteLine( Aluno1 + " teve a maior média."); }
            else if (MediaNota2 > MediaNota1 && MediaNota2 > MediaNota3)
            { Console.WriteLine( Aluno2 + " teve a maior média."); }
            else if (MediaNota3 > MediaNota1 && MediaNota3 > MediaNota2)
            { Console.WriteLine( Aluno3 + " teve a maior média."); }


            Console.WriteLine("-----------------------Menor Média-----------------------------");
            if (MediaNota1 < MediaNota2 && MediaNota1 < MediaNota3)
            { Console.WriteLine(Aluno1 + " teve a menor média."); }
            else if (MediaNota2 < MediaNota1 && MediaNota2 < MediaNota3)
            { Console.WriteLine(Aluno2 + " teve a menor média."); }
            else if (MediaNota3 < MediaNota1 && MediaNota3 < MediaNota2)
            { Console.WriteLine(Aluno3 + " teve a menor média."); }


            Console.ReadKey();

            //fazendo atualização dos codigos

        }
    }
}
