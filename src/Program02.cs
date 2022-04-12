using System;
using System.Globalization; 

namespace Start
{
    class Program02
    {
        static void Main02(string[] args)

        {	   
        NumberFormatInfo numberFormat = null;
        CultureInfo info = CultureInfo.InstalledUICulture;
        numberFormat = (NumberFormatInfo)
        info.NumberFormat.Clone();
        numberFormat.NumberDecimalSeparator = ".";
            double A, B, C;
            A = double.Parse(Console.ReadLine(), numberFormat);
            B = double.Parse(Console.ReadLine(), numberFormat);
            C = double.Parse(Console.ReadLine(), numberFormat);

            double total =( A*2 + B*3 + C*5 )/ 10;
            Console.WriteLine( "MÉDIA = {0:F1}", total);                                  
            Console.ReadKey();
        }
    }
}