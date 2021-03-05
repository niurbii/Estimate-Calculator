using System;

public class Program
{
    static void calculateResult(double price, int hours, int techs) {
        double percent = (price * 0.07);
        double profit = (percent + price) / 0.7;
        int labor;
        if (techs == 2) {
            labor = (hours * 175) + 100;
        } else {
            labor = (hours * 125) + 100;
        }
        double result = labor + profit;
        Console.WriteLine(result);
}

public static void Main()
{
    Console.WriteLine("Enter price:");
    double inputPrice = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter hours:");
    int inputHours = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter techs:");
    int inputTechs = Convert.ToInt32(Console.ReadLine());

    calculateResult(inputPrice, inputHours, inputTechs);
    }
}