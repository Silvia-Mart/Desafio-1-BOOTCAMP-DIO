using System;

namespace Uri1078
{
    class Program
    {
        static void Main04(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            for ( int x = 1; x <= 10 ; x++   )
            {
                Console.WriteLine(string.Format($"{x} x {n} = {x*n}" )); //escreva o seu código nos espaços em branco
            }
        }
    }
}