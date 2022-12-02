using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Add(2, 4);
            Add(4.54m, 5.32m);
            Add(1, 2, true);

             
        }

        public static void Add(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }

        public static void Add(decimal num1, decimal num2)
        {
            Console.WriteLine(num1 + num2);
        }

        public static void Add(int num1, int num2, bool a)
        {
            var sum = num1 + num2;
            if  (a && sum > 1)
            {
               
                Console.WriteLine($"{sum} dollars");
            }
            if(num2 + num1 == 1)
            {
                
                Console.WriteLine($"{sum} dollar");
            }
            else
            {
                return;
            }
                





        }

    }
}
