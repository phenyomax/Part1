using System;

namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new Recipe instance
            Recipe recipe = new Recipe();

            // the user to enter the number of ingredients
            Console.WriteLine("Enter the number of ingredients:");
            int ingredientCount = int.Parse(Console.ReadLine());

            // Loop to input ingredients
            for (int i = 0; i < ingredientCount; i++)
            {
                // Prompt the user to enter the name of the ingredient
                Console.WriteLine("Enter the name of ingredient {i + 1}:");
                string name = Console.ReadLine();

                //the user to enter the quantity of the ingredient
                Console.WriteLine("Enter the quantity of {name}:");
                double quantity = double.Parse(Console.ReadLine());

                // Prompt the user to enter the unit of measurement for the ingredient
                Console.WriteLine("Enter the unit of measurement for {name}: e.g (1 tablespoon of salt");
                string unit = Console.ReadLine();

                // Add the ingredient to the recipe
                recipe.AddIngredient(name, quantity, unit);
            }

            // Prompt the user to enter the number of steps
            Console.WriteLine("Enter the number of steps:");
            int stepCount = int.Parse(Console.ReadLine());

            // Loop to input steps
            for (int i = 0; i < stepCount; i++)
            {
                // Prompt the user to enter each step
                Console.WriteLine("Enter step {i + 1}:");
                string stepDescription = Console.ReadLine();

                // Add the step to the recipe
                recipe.AddStep(stepDescription);
            }

            // Display the recipe
            recipe.DisplayRecipe();

            // Prompt the user to enter a scaling factor
            Console.WriteLine("Enter a scaling factor (0.5 for half, 2 for double, 3 for triple):");
            double scale = double.Parse(Console.ReadLine());
            recipe.SaveOriginalQuantities();
            recipe.ScaleRecipe(scale);
            recipe.DisplayRecipe();

            // the user to reset quantities or clear all data
            Console.WriteLine("Enter 'reset' to reset quantities to original values, 'clear' to clear all data, or any other key to exit:");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "reset":
                    recipe.ResetQuantities();
                    recipe.DisplayRecipe();
                    break;
                case "clear":
                    recipe.ClearRecipe();
                    Console.WriteLine("Recipe data cleared.");
                    break;
                default:
                    break;
            }
        }
    }
}
