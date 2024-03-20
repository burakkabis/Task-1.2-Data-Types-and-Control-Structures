using System;

namespace Data_Types_and_Control_Structures
{
    public class Program
    {

        public static float CalculateAverage(int[] numbers)
        {
            if (numbers == null)
            { 
                throw new ArgumentNullException("Array can not be null");
            }
            if (numbers.Length == 0)
            { 
                throw new ArgumentException("Array can not be empty");
            }

            int sum=0;
            foreach (int num in numbers)
            {
                sum += num;
            }

            return (float)sum/numbers.Length;
        }
        static void Main(string[] args)
        {

            int[] numbers = { 1,2,3,4,5,6,7,8,9,10};

            Console.WriteLine("Avearege number is: " + CalculateAverage(numbers));

            int[] numbers2 = { };
            try
            {
                Console.WriteLine("Average number is:" + CalculateAverage(numbers2));


            }

            catch (ArgumentException exception)
            {
                Console.WriteLine("Error:"+exception.Message);
            }

            int[] numbers3 = null;

            try
            {

                Console.WriteLine(CalculateAverage(numbers3));

            }

            catch (ArgumentException exception)
            
            {

                Console.WriteLine("Error:"+exception.Message);
                
            }

        }
    }
}
    