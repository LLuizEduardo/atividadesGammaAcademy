using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade5
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = "\n ---------------------------------------------------";

            Console.WriteLine("Digite quantos alunos tem a escola:");
            var qtdAlunos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(texto);

            for (int i = 1; i <= qtdAlunos; i++)
            {
                Console.WriteLine($"Digite os dados do {i}º aluno:");
                Console.WriteLine("Nome:");
                var nomeAluno = Console.ReadLine();
                Console.WriteLine("Matricula:");
                var matricula = Console.ReadLine();
                Console.WriteLine("Primeira nota:");

                double nota1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Segunda nota:");
                double nota2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Terceira nota:");
                double nota3 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(texto);


               List<dynamic> dadosAlunos = new List<dynamic>();
                dadosAlunos.Add(new {
                    nome = nomeAluno[i],
                    mat = matricula[i],
                    priNota = nota1,
                    segNota = nota2,
                    terNota = nota3,                    
            });
                Console.WriteLine(dadosAlunos[i].nome);
            }

        //    for (int i = 1; i <= qtdAlunos; i++)
        //    {
        //        Console.WriteLine(dadosAlunos[i].nome);               
        //    }


            Console.ReadKey();

        }
    }
}
