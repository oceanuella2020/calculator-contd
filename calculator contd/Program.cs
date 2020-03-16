using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator_contd
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2,number3;
            number1 = Int32.Parse("32");
            number2 = Int32.Parse("34");
            number3 = Int32.Parse("23");
            Console.WriteLine(number1.ToString() + "+" + number2.ToString()+ "+" +number3.ToString() + "=" + (number1 + number2 + number3).ToString());
            Console.ReadKey();
        }
    }
}
