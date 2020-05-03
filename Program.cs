using System;

namespace consoleproject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your weight(lb)? ");
            float weight = float.Parse(Console.ReadLine());

            Console.Write("\nWhat is your height\n");
            Console.Write("Feet? ");
            float height_feet = float.Parse(Console.ReadLine());
            Console.Write("Inches? ");
            float height_inches = float.Parse(Console.ReadLine());

            float total_height_inches = (height_feet * 12) + height_inches;
            double height_squared = Math.Pow(total_height_inches, 2);

            double BMI = (weight / height_squared) * 703;

            Console.WriteLine("\nYour BMI is: {0}", Math.Round(BMI, 2));
        }
    }
}
