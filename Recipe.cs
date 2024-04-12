using System;
using System.Collections.Generic;

namespace Part1
{
    public class Recipe
    {
        // Store original ingredient quantities
        private List<Ingredient> originalIngredients; 

        public List<Ingredient> Ingredients { get; set; }
        public List<Step> Steps { get; set; }

        public Recipe()
        {
            Ingredients = new List<Ingredient>();
            Steps = new List<Step>();
        }

        // Method to add an ingredient to the recipe
        public void AddIngredient(string name, double quantity, string unit)
        {
            Ingredients.Add(new Ingredient { Name = name, Quantity = quantity, Unit = unit });
        }

        // Method to add a step to the recipe
        public void AddStep(string description)
        {
            Steps.Add(new Step { Description = description });
        }

        // Method to display the recipe
        public void DisplayRecipe()
        {
            Console.WriteLine("Recipe:");
            Console.WriteLine("Ingredients:");
            foreach (var ingredient in Ingredients)
            {
                Console.WriteLine($"{ingredient.Quantity} {ingredient.Unit} of {ingredient.Name}");
            }
            Console.WriteLine("Steps:");
            for (int i = 0; i < Steps.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Steps[i].Description}");
            }
        }

        // Method to scale the recipe by a factor
        public void ScaleRecipe(double factor)
        {
            foreach (var ingredient in Ingredients)
            {
                ingredient.Quantity *= factor;
            }
        }

        // Method to save original quantities before scaling
        public void SaveOriginalQuantities()
        {
            originalIngredients = new List<Ingredient>(Ingredients);
        }

        // Method to reset ingredient quantities to original values
        public void ResetQuantities()
        {
            if (originalIngredients == null)
            {
                Console.WriteLine("Original quantities are not saved. Please scale the recipe first.");
                return;
            }

            for (int i = 0; i < Ingredients.Count; i++)
            {
                Ingredients[i].Quantity = originalIngredients[i].Quantity;
            }
        }

        // Method to clear all data from the recipe
        public void ClearRecipe()
        {
            Ingredients.Clear();
            Steps.Clear();
        }
    }
}
