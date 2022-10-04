using Bridge.Model;
using System;
using System.Collections.Generic;


public class Program
{
    public static void Main(string[] args)
    {
        var calculate = new CalCulate(new EventNode());
        Console.WriteLine($"{calculate.CalculateSum()}");
        Console.WriteLine($"{calculate.CalculateSum()}");
        Console.WriteLine($"{calculate.CalculateDivision()}");

        calculate.CalculateObj = new GateNode();
        Console.WriteLine($"{calculate.CalculateSum()}");
        Console.WriteLine($"{calculate.CalculateSum()}");
        Console.WriteLine($"{calculate.CalculateDivision()}");
    }
}
