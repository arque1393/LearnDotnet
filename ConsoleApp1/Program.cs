// See https://aka.ms/new-console-template for more information

using Humanizer;

using System;
class Program{

    static void HumanizeQuantities()
    {
        Console.WriteLine("case".ToQuantity(0));
        Console.WriteLine("case".ToQuantity(1));
        Console.WriteLine("case".ToQuantity(5));
    }
    static void HumanizeDates()
    {
        Console.WriteLine(DateTime.UtcNow.AddHours(-24).Humanize());
        Console.WriteLine(DateTime.UtcNow.AddHours(-2).Humanize());
        Console.WriteLine(TimeSpan.FromDays(1).Humanize());
        Console.WriteLine(TimeSpan.FromDays(16).Humanize());
    }
    public static void Main(string[] argv){

        int n,n1,n2,sum;
        n=10;n1=2;n2=2;sum=0;
        for (int i = 2; i <= n; i++)
        {                  
            sum = n1 + n2;
            n1 = n2;
            n2 = sum;
            Console.WriteLine($"sum is 1, n1 is {n1}, n2 is {n2}");    
        }
    }
}