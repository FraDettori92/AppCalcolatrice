﻿using AppCalcolatrice;

public class Program
{
    public static void Main(string[] args)
    {
        var calc = new Calcolatrice();
        calc.HomeCalcolatrice();
        var inputUtente = Console.ReadLine();
        calc.ProcessaSoluzione(inputUtente);
    }
}