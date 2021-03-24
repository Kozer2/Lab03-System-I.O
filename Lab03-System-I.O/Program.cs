using System;

namespace Lab03_System_I.O
{
    public class Program
    {
       
        public static void Main(string[] args)
        {
            string  result = GetArrForChallenge1();
            int product = Challenge1(result);
            Console.WriteLine($"The product of the numbers is: {product}.");
        } // end main



        public static string GetArrForChallenge1()
        {
            
            Console.WriteLine("Input 3 numbers");
            string userInput = Console.ReadLine();

            return userInput;
        }
        public static int Challenge1(string words)
        {
            int a = 1;
            int b = 1;
            int c = 1;
            int result = 0;
            string[] arr = words.Split();
            if(arr.Length < 3)
            {
                result = 0;
            }
            else
            {
                try
                {
                    a = Convert.ToInt32(arr[0]);
                    b = Convert.ToInt32(arr[1]);
                    c = Convert.ToInt32(arr[2]);
                    result = (Math.Abs(a * b * c));
                }
                catch (FormatException)
                {
                     a = 1;
                     b = 1;
                     c = 1;
                    result = (Math.Abs(a * b * c));
                }
                
            }

             
         
            return result;
        } // end Challenge1
    }
}
