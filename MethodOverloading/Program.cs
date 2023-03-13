using System.Diagnostics.CodeAnalysis;
using System.Threading.Channels;

namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(3, 5));
            Console.WriteLine(Add(3.0m, 9.8m));
            Console.WriteLine(Add(5, 4, true));


        }

        public static int Add(int x, int y)
        {
            return x + y;
            
        }

        public static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }

        public static string Add(int x, int y, bool isChecked)
        {
            var dollars = x + y;


            if (isChecked == true && x + y == 1)
            {
                return ($"{dollars} dollar");

            }
            else if (isChecked == true && dollars > 1)
            {
                return ($"{dollars} dollars");
            }
            else if (isChecked == true && dollars < 0)
            {
                return ($"With the amount of {dollars}$ in your account.\nYou are in debt.");
            }
            else
            {
                return ("This is not secure");
            }
           
        }

    }


}
