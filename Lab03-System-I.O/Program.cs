using System;

namespace Lab03_System_I.O
{
    public class Program
    {
       
        public static void Main(string[] args)
        {
            /*string  result = GetArrForChallenge1();
            int product = Challenge1(result);
            Console.WriteLine($"The product of the numbers is: {product}.");*/


            int[] result = GetArrForChallenge2();
            int average = Challenge2(result);
            Console.WriteLine($"The average of those numbers is: {average}.");

        } // end main



        public static string GetArrForChallenge1()
        {
            
            Console.WriteLine("Input 3 numbers");
            string userInput = Console.ReadLine();

            return userInput;
        } // end GetArrForChallenge1
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
            } // end if
            else
            {
                try
                {
                    a = Convert.ToInt32(arr[0]);
                    b = Convert.ToInt32(arr[1]);
                    c = Convert.ToInt32(arr[2]);
                    result = (Math.Abs(a * b * c));
                } // end try
                catch (FormatException)
                {
                    /*for (int i = 0; i < arr.Length; i++)
                    {
                        if(arr[i] != Type.int); 
                    }*/
                     a = 1;
                     b = 1;
                     c = 1;
                    result = (Math.Abs(a * b * c));
                } // end catch
                
            } // end else
            return result;
        } // end Challenge1

        public static int[] GetArrForChallenge2()
        {

            Console.WriteLine("Enter a number betwen 2 and 10");
            int arraySize = 0;
            while (true)
            {
                try
                {
                    int userInput = Convert.ToInt32(Console.ReadLine());
                    if (userInput < 2 || userInput > 10)
                    {
                        Console.WriteLine("The number you entered is not between 2 and 10. Try again.");

                    } // end if
                    else
                    {
                        arraySize = userInput;
                        break;
                    } // end else
                    

                } // end try
                catch (FormatException)
                {
                   
                    Console.WriteLine("That was not a number you entered.");
                    
                } // end catch
                
            } // end while
            int[] arrayToMaths = new int[arraySize];
            
            for (int i = 0; i < arrayToMaths.Length; i++)
            {
                Console.WriteLine($"Enter a number: {i + 1} of {arraySize}");
                while (true)
                {
                    try
                    {
                        int userNum = Convert.ToInt32(Console.ReadLine());
                        arrayToMaths[i] = userNum;
                        break;
                    } // end try
                    catch (FormatException)
                    {

                        Console.WriteLine("That was not a number you entered.");

                    } // end catch
                }// end while
                
            } // end for loop


            return arrayToMaths;
        } // end challenge 2 builder


        public static int Challenge2(int[] arr)
        {
            int total = 0;
            int arrSize = arr.Length;
            if (arrSize > 10 || arrSize < 2)
            {
                throw new IndexOutOfRangeException("Incorrect array length");
            }// end if
            for (int i = 0; i < arrSize; i++)
            {
                total = total + arr[i];
            }// end for

            int average = total / arrSize;
            return average;
        } // end Challenge2 


    }
}
