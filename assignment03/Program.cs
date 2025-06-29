using System.ComponentModel;
using System.Security.Cryptography;

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
            //4- Write a program that allows the user to insert an integer number then check If a number is even or odd.
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(n % 2 == 0 ? "Even" : "Odd");
            #endregion


            #region q5
            //5- Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
            char ch = char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine((ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u') ? "\nvowel" : "\nconsonant");



            #endregion

            #region q6
            //6- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.

            int limit = int.Parse(Console.ReadLine());
            for (int i = 1; i <= limit; i++)
                Console.Write(i + " ");

            #endregion
            #region q7
            // 7 - Write a program that allows the user to insert an integer then  print a multiplication table up to 12.
            int m = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 12; i++)
                Console.Write((m * i) + " ");
            #endregion
            #region q8
            //8- Write a program that allows to user to insert number then print all even numbers between 1 to this number
            int x = int.Parse(Console.ReadLine());
            for (int i = 1; i <= x; i++)
            {
                if (i % 2 == 0)
                    Console.Write(i + " ");
            }
            #endregion
            #region q9
            //9- Write a program that takes two integers then prints the power.
            Console.WriteLine("Enter base number:");
            int basen = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter ppwer number:");
            int power = int.Parse(Console.ReadLine());
            int result = (int)Math.Pow(basen, power);
            Console.WriteLine(result);
            #endregion
            #region q10
            //10- Write a program to enter marks of five subjects and calculate total, average and percentage.

            int total = 0;
            for (int i = 0; i < 5; i++)
                total += int.Parse(Console.ReadLine());

            double average = total / 5.0;
            Console.WriteLine("Total marks = " + total);
            Console.WriteLine("Average Marks = " + average);
            Console.WriteLine("Percentage = " + average*100 +"%");
            #endregion
            #region q11
            //11- Write a program to input the month number and print the number of days in that month.

            int month = int.Parse(Console.ReadLine());
            int days = DateTime.DaysInMonth(2024, month);
            Console.WriteLine("Days in Month: " + days);
            #endregion
            #region q12
            // Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.
            int size = int.Parse(Console.ReadLine());
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                    Console.Write(i == j ? "1 " : "0 ");
                Console.WriteLine();
            }
            #endregion
            #region q13
            //13- Write a program in C# Sharp to find the sum of all elements of the array.
            int[] arr = { 1, 2, 3, 4, 5 };
            int sum = 0;
            foreach (int num in arr)
            {
                sum += num;
            }
            Console.WriteLine("Sum of array elements: " + sum);
            #endregion
            #region q14
            //14- Write a program in C# Sharp to count the frequency of each element of an array.
          

       
          
                int[] arr = { 1, 3, 2, 1, 4, 3, 2, 1 };
                int[] freq = new int[arr.Length];
                int visited = -1;

                for (int i = 0; i < arr.Length; i++)
                {
                    int count = 1;
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            count++;
                            freq[j] = visited;
                        }
                    }

                    if (freq[i] != visited)
                        freq[i] = count;
                }

                Console.WriteLine("Element | Frequency");
                for (int i = 0; i < freq.Length; i++)
                {
                    if (freq[i] != visited)
                        Console.WriteLine($"   {arr[i]}    |    {freq[i]}");
                }
            //it's not working 
            #endregion


            #region q15
            // Write a program in C# Sharp to find maximum and minimum element in an array

            int[] nums = { 4, 2, 7, 1, 9 };
            int max = nums.Max();
            int min = nums.Min();
            Console.WriteLine("Max = " + max);
            Console.WriteLine("Min = " + min);

            #endregion

            #region q16
            //16- Write a program in C# Sharp to find the second largest element in an array.
            int[] numbers = { 5, 3, 8, 1, 4 };
            Array.Sort(numbers);
            int secondLargest = numbers[numbers.Length - 2];
            Console.WriteLine("Second largest element: " + secondLargest);
            #endregion


        }
}
}
