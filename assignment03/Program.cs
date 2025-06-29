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

        }
    }
}
