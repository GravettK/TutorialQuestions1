using System.Text.RegularExpressions;
using System.Linq;

namespace TutorialQuestions1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            var name = Console.ReadLine();

            Console.WriteLine("Enter your age: ");
            var age = Console.ReadLine();

            // Regex pattern to check if the name contains a number or special character
            string pattern = @"[\d\W_]";
            //[\d\W_]: This pattern matches any digit (\d) or non-word character (\W), including underscores (_).

            // Check if the name matches the pattern

            if (Regex.IsMatch(name, pattern))
            {
                Console.WriteLine("Invalid name: Name should not contain numbers or special characters.");
            }
            else
            {
                Console.WriteLine("Valid name: Name does not contain numbers or special characters.");
            }

            int [] grade = {10, 45, 60, 98, 69, 72, 99};
            var avg = Queryable.Average(grade.AsQueryable());//Using the linq Avergae Method.
            avg = Math.Round(avg, 2);
            Console.WriteLine("Class average is: " + avg);

            long a = 0, b = 1, c = 0;
            Console.WriteLine("Enter the number of terms you would like to reach: ");
            int iterations  = int.Parse(Console.ReadLine());

            Console.WriteLine("1");
            for(int i = 0; i < iterations; i++) 
            {
                
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
            }

            Console.WriteLine("Enter a string for manipulation: ");
            String gasLight = Console.ReadLine();
            Console.WriteLine("Reveresed: " +); 


        }
    }
}
