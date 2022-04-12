using System;
using System.Globalization; 
 
class DIO01{
 
    static void Main01(string[] args) {
	    NumberFormatInfo numberFormat = null;
        CultureInfo info = CultureInfo.InstalledUICulture;
        numberFormat = (NumberFormatInfo)
        info.NumberFormat.Clone();
        numberFormat.NumberDecimalSeparator = ".";

        string[] input;

	      input = Console.ReadLine().Split(' ');
        int cod1 = int.Parse(input[0]);
        int n1 = int.Parse(input[1]);
        double valor1 = double.Parse(input[2],numberFormat);
     //Escreva sua lógica nos espaços em branco
 	      input = Console.ReadLine().Split(' ');
        int cod2 = int.Parse(input[0]);
	      int n2  = int.Parse(input[1]);
        double valor2 = double.Parse(input[2],numberFormat);

        double total = n1 * valor1 + n2 * valor2 ;
        Console.WriteLine("VALOR A PAGAR: R$ {0:F2}", total);
    }

}