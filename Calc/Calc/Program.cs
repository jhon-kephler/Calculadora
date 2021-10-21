using System;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Digite um Numero: ");
            int limite = int.Parse(Console.ReadLine());

            int num = 0;
            var res = 0;

            while (num <= limite)
            {
                               
                if (num % 3 == 0)
                {
                    res += num;
                }
                if (num % 5 == 0)
                {
                    res += num;
                }

                num++;
            }
            Console.WriteLine(res);
            Console.ReadKey();

        }
    }
}
