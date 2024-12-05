using System;

public class Program
{
    public static int CountBits(int num)
    {
        string binaryRepresentation = Convert.ToString(num, 2);

        int count = 0;
        foreach (char bit in binaryRepresentation)
        {
            if (bit == '1')
            {
                count++;
            }
        }
        return count;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Введите число для подсчета значащих битов:");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine($"Количество значащих битов: {CountBits(num)}");
    }
}
