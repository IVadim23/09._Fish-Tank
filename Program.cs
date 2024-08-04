using System;

namespace _09._Fish_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add length to side a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Add length to side b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Add length to side c");
            int c = int.Parse(Console.ReadLine());
            int all = a * b * c;
            double volumeinLiters = all * 0.001;
            Console.WriteLine("Add ocupied space:");
            double occupiedSpace = double.Parse(Console.ReadLine());
            double spaceOccupiedAsPercentage = occupiedSpace / 100;
            double requiredLiters = volumeinLiters * (1 - spaceOccupiedAsPercentage);
            Console.WriteLine("The required liters are:\n {0:f2}",requiredLiters);
        }
    }
}
