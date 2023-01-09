using System;

namespace squareArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ESTE PROGRAMA CALCULA EL AREA DE UN RECTANGULO
            Console.WriteLine("Por favor ingresa el lado A del rectangulo, puedes usar decimales\n");
            float sideA = float.Parse(Console.ReadLine());

            Console.WriteLine("Por favor ingresa el lado B del rectangulo, puedes usar decimales\n");
            float sideB = float.Parse(Console.ReadLine());

            //sideB--;
            //sideB--;
            //la formula del rectangulo es a*b
            float area = sideA * sideB;

            Console.WriteLine("El área del rectangulo es: " + area);
        }
    }
}
