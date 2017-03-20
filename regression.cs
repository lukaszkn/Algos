using System;
 
class Regression
{
    static void Main(string[] args)
    {
        double[] values = { 4.8, 4.8, 4.5, 3.9, 4.4, 3.6, 3.6, 2.9, 3.5, 3.0, 2.5, 2.2, 2.6, 2.1, 2.2 };
 
        double xAvg = 0;
        double yAvg = 0;
 
        for (int x = 0; x < values.Length; x++)
        {
            xAvg += x;
            yAvg += values[x];
        }
 
        xAvg = xAvg / values.Length;
        yAvg = yAvg / values.Length;
 
        double v1 = 0;
        double v2 = 0;
 
        for (int x = 0; x < values.Length; x++)
        {
            v1 += (x - xAvg) * (values[x] - yAvg);
            v2 += Math.Pow(x - xAvg, 2);
        }
 
        double a = v1 / v2;
        double b = yAvg - a * xAvg;
 
        Console.WriteLine("y = ax + b");
        Console.WriteLine("a = {0}, the slope of the trend line.", Math.Round(a, 2));
        Console.WriteLine("b = {0}, the intercept of the trend line.", Math.Round(b, 2));
 
        Console.ReadLine();
    }
}