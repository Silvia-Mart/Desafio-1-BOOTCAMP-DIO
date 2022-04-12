using System;

namespace DIO09
{
    class Program09
    {
        static void Main09(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int inicio = 1;
             

            for (int i = 1; i <= n; i++)
            {
                for(int j = 1; j<= 3; j++){
                    Console.Write($"{Math.Pow(inicio,j)} ");
                }
                inicio++;
                Console.WriteLine();
                 //escreva aqui o seu código
                
            }
        }
    }
}