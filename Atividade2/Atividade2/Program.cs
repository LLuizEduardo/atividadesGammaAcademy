using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2
{
    class Program
    {
        static void Main(string[] args)
        {
            string sec = ("---------------------------------------------------------------");

            Console.WriteLine(sec);
            double valorKg = 1.50;
            Console.WriteLine("O valor do Kg é $" + valorKg);
            Console.WriteLine("Deseja quantos quilogramas de lentilha?");
            double qtdKg = Convert.ToDouble(Console.ReadLine());

            double total = valorKg * qtdKg;

            Console.WriteLine("-----------------------Resultados------------------------------");
            Console.WriteLine("Peso total Kg " + qtdKg);
            Console.WriteLine("Valor total $ " + total);
            Console.WriteLine(sec);

            Console.ReadKey();

        }
    }
}
