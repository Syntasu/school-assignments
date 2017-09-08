using System;

class Program
{
    static void Main(string[] args)
    {
        double grade1 = 5.5;
        double grade2 = 4.5;
        double grade3 = 7.5;

        double avg = GetAverage(grade1, grade2, grade3);
        string avgResult = avg >= 5.5 ? "passed" : "failed";
  
        Console.WriteLine($"{avgResult} with a {avg}");

        Console.ReadKey();
    }

    private static double GetAverage(params double[] grades)
    {
        double accum = 0.0;

        for (int i = 0; i < grades.Length; i++)
        {
            accum += grades[i];
        }

        return accum / grades.Length;
    }
}
