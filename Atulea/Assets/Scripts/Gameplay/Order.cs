using UnityEngine;

public class Order
{
  // List of ingredients for the order, checked against the provided drink
  public Recipe recipe;
  private int price;
  private Drink drink;

  // Iterate through each ingredient in the list and compare it to the drink's ingredients
  // Return false if any ingredient does not match
  public bool checkIngredients(Drink drink)
  {
    if (this.drink.ingredients.Count != drink.ingredients.Count)
    {
      Debug.Log("Wrong number of ingredients!");
      return false;
    }
    for (int i = 0; i < drink.ingredients.Count; i++)
    {
      // Check if the ingredient types match (e.g., Shot, Milk, etc.)
      if (this.drink.getIngredient(i).ingredientType.GetType() != drink.getIngredient(i).ingredientType.GetType()
      || this.drink.getIngredient(i).specificType.GetType() != drink.getIngredient(i).specificType.GetType())
      {
        return false;
      }
    }
    return true;
  }

  public Order(Recipe recipe)
  {
    drink = new Drink();
    drink.addIngredients(recipe.Ingredients);
    price = recipe.Points;
  }
  

}