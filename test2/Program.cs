using System;

public class Program
{
    public static void Main(string[] args)
    {
        int number1 = 12345;
        int number2 = 67890;
        double averageSum = CalculateAverageSum(number1, number2);
        Console.WriteLine("Среднее арифметическое сумм цифр: " + averageSum);
    }

    public static double CalculateAverageSum(int number1, int number2)
    {
        double sum1 = CalculateDigitSum(number1);
        double sum2 = CalculateDigitSum(number2);
        double averageSum = (sum1 + sum2) / 2;
        return averageSum;
    }

    public static int CalculateDigitSum(int number)
    {
        int sum = 0;
        while (number != 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }
}