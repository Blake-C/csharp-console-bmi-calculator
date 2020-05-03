using System;

namespace bmicalculator
{
    class bmicalculator
    {
        static void Main(string[] args)
        {
            // https://www.cdc.gov/healthyweight/assessing/bmi/childrens_bmi/childrens_bmi_formula.html

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

            Console.WriteLine("\nYour BMI is: {0}\n", Math.Round(BMI, 2));

            if (BMI < 18.5)
            {
                Console.WriteLine("You are underweight");
            }
            else if (BMI >= 18.5 && BMI <= 24.9)
            {
                Console.WriteLine("You are normal weight");
            }
            else if (BMI >= 25 && BMI <= 29.9)
            {
                Console.WriteLine("You are overweight");
            }
            else
            {
                Console.WriteLine("You are obese");
            }
        }
    }
}
