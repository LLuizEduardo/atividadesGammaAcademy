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
            string texto = "------------------------------------------------";

            Console.WriteLine(texto);
            Console.Write("Digite quantos alunos tem a escola:  ");
            var qtdAlunos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            for (int i = 1; i <= qtdAlunos; i++)
            {
                Console.WriteLine(texto);
                Console.WriteLine($"----------Digite os dados do {i}º aluno:----------");
                Console.WriteLine(texto);
                Console.Write("Nome:    ");
                var nomeAluno = Console.ReadLine();
                //Console.Write("Matricula:");
                // var matricula = Console.ReadLine();

                Console.Write("Nota 1:  ");
                double nota1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Nota 2:  ");
                double nota2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Nota 3:  ");
                double nota3 = Convert.ToDouble(Console.ReadLine());

                var media = (nota1 + nota2 + nota3) / 3;
                string situacao = (media >= 7 ? "Situação: Aprovado (a)" : "Situação: Não Aprovado (a)");

                List<dynamic> dadosAlunos = new List<dynamic>();
                dadosAlunos.Add(new
                {
                    Nome = nomeAluno,
                    Notas = new List<double>(){nota1, nota2, nota3},
                    Media = media,
                    Situacao = situacao

                    /*nomeAluno, nota1, nota2, nota3, media, situacao*/
                });

                foreach (dynamic v in dadosAlunos)
                {
                    Console.WriteLine("-------------------Resultados-------------------");
                    Console.WriteLine($"Nome    : {nomeAluno}");
                    Console.WriteLine($"Notas   : {nota1}, {nota2}, {nota3}");
                     Console.WriteLine($"Média   : {media}");
                    Console.WriteLine(situacao);
                    Console.WriteLine(texto + "\n\n\n");
                }
            }

            Console.ReadKey();
        }
    }
}
