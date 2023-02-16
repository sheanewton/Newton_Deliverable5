namespace Newton_Deliverable5
{

    using System;
    internal class Program
    {
        static int[] random_array(int array_len)
        {
            Random random = new Random();
            int[] MyArray = new int[array_len];
            for (int i = 0; i < array_len; i++)
            {
                MyArray[i] = random.Next(10, 50);
            }

            return MyArray;
        }

        static int sum(int[] array)
        {
            int sum = 0;
            foreach (int item in array)
            {
                sum = sum + item;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int input = 0;
            bool valid = false;
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter an integer number between 5 and 15: ");
                    input = int.Parse(Console.ReadLine());

                    if (input < 5 || input > 15)
                    {
                        Console.WriteLine("Invalid integer. Please use an integer between 5 and 15.");
                    }
                    else
                    {
                        int[] sampleArray = random_array(input);

                        foreach (int element in sampleArray)
                        {
                            Console.WriteLine(element + " ");
                        }

                        Console.WriteLine(" ");
                        Console.WriteLine("The sum is: " + sum(sampleArray));
                    }


                }
                catch (FormatException) { }



            }
        }
    }
}