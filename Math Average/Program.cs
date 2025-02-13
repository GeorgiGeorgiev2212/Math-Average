//сумиране на числа и изписване на средното
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        //Math average
        Console.WriteLine("Write the numbers that you need to average");

        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int z = int.Parse(Console.ReadLine());


        int sum = a + b + c + d + x + y + z;
        double arithmetic = sum / 7;


        Console.WriteLine("The average number is: " + arithmetic);
    }
}