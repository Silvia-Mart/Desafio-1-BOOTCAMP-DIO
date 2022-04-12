using System;

namespace TESTE {
    class Program07 {
        static void Main07(string[] args) {
        
            int N = int.Parse(Console.ReadLine());

            int primeiro = 1;
            int segundo = 2;
            int terceiro = 3;

            for (int i = 1; i <= N; i++) 
            {
                Console.WriteLine($"{primeiro} {segundo} {terceiro} PUM");
                primeiro += 4;
                segundo += 4;
                terceiro += 4;
               // Insira o seu código aqui


            }
        }
    }
}