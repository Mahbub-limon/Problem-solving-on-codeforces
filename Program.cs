

using System;

class Program
{
    static void Main()
    {
        string[] inputs = Console.ReadLine().Split();
        long n = long.Parse(inputs[0]);
        long m = long.Parse(inputs[1]);
        long a = long.Parse(inputs[2]);

        // Calculating the number of flagstones
        long flagstonesLength = (n + a - 1) / a;
        long flagstonesWidth = (m + a - 1) / a;

        // Total flagstones needed
        long totalFlagstones = flagstonesLength * flagstonesWidth;
        Console.WriteLine(totalFlagstones);
    }
}

