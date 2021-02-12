using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace broadwayproject1
{
    public class Program
    {
        static void Main(string[] args)
            
        {
            mathops();
            Console.ReadLine();


        }
        static void mathops()
        {
            Console.Write("Enter the First Number:");
            var a = Console.ReadLine();
            Console.Write("Enter the Second Number:");
            var b = Console.ReadLine();

            var num_a = Convert.ToDecimal(a);
            var num_b = Convert.ToDecimal(b);

            math Math = new math();

            Console.WriteLine("Addation " + Math.Add(num_a, num_b));
            Console.WriteLine("Subtraction {0}" , Math.Subtract(num_a, num_b));
            Console.WriteLine("Multiplication " + Math.multiply(num_a, num_b));
            Console.WriteLine("Division " + Math.divide(num_a, num_b));


        }
    }
}
