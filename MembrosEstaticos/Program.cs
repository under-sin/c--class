﻿using System;
using System.Globalization;

namespace MembrosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            double vol = Calculadora.Volume(raio);


            Console.WriteLine("Circunferência: " + circ.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + vol.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Calculadora.Pi.ToString("f2", CultureInfo.InvariantCulture));
        }


    }
}
