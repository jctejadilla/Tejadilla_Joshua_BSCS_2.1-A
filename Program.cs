using System;
namespace ComputeAverageApp{

public class ComputeAverageProgram
{
    public static void Main(string[] args)
    {
        
        double[] grades = new double[5];

        for (int i = 0; i < grades.Length; i++)
        {
            Console.Write($"Enter grade {i + 1}: ");
            grades[i] = double.Parse(Console.ReadLine());
        }
        
        double sum = 0;
        for (int i = 0; i < grades.Length; i++)
        {
            sum += grades[i];
        }
        double average = sum / grades.Length;
        double roundedAverage = Math.Round(average);
        
        Console.WriteLine($"The average of the grades is: {average:F2}");
        Console.WriteLine($"The rounded average is: {roundedAverage}");
    }
}
}