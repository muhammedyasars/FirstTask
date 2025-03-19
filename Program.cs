using System;
public class Program
{
    static bool Prime(int number)
    {
        if (number < 2)
        {
            return false;
        }
        for (int i = 2; i < Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }
    static void Main()
    {
        while (true)
        {


            Console.WriteLine("enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            if (Prime(num))
            {
                Console.WriteLine(num + " is prime");
            }
            else
            {
                Console.WriteLine(num + " is not prime");

            }
        }
    }
}

