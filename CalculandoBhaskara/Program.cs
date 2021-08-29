using System;

namespace CalculandoBhaskara
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("Bem vindo(a) ao Bhaskara Fácil!");
            Console.WriteLine("Em caso de valores decimais, utilize ponto ao invés de vírgula");
            Console.WriteLine();

            Console.Write("Informe o valor de A: ");
            double a = double.Parse(Console.ReadLine());
            
            Console.Write("Informe o valor de B: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Informe o valor de C: ");
            double c = double.Parse(Console.ReadLine());

            double delta = Math.Pow(b, 2) - (4 * a * c);
            Console.Write("O valor de delta é: {0}", delta);
            Console.WriteLine();

            if (delta < 0)
            {
                Console.WriteLine("O valor de delta é negativo, portanto não há solução!");
            }

            else
            {
                double resultado1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double resultado2 = (-b - Math.Sqrt(delta)) / (2 * a);

                Console.Write("O primeiro resultado possível é: {0}", resultado1);
                Console.WriteLine();
                Console.Write("O segundo resultado possível é: {0}", resultado2);
            }


            
            
        }
    }
}
