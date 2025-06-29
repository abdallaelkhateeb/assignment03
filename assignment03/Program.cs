using System.ComponentModel;

namespace assignment03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region q1
            //1 - Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine((num % 3 == 0 && num % 4 == 0) ? "Yes" : "No");

            #endregion

            #region q2
           // 2 - Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.

            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(number < 0 ? "Negative" : "Positive");
            #endregion


            #region q3
            // 3- Write a program that takes 3 integers from the user then prints the max element and the min element.
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int max = Math.Max(a, Math.Max(b, c));
            int min = Math.Min(a, Math.Min(b, c));

            Console.WriteLine("max element = " + max);
            Console.WriteLine("min element = " + min);


            #endregion
            #region q4
            
            #endregion
        }
    }
}
