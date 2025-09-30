using UnityEngine;
using System.Collections.Generic;

public class Order
{
  // List of ingredients for the order, checked against the provided drink
  public List<Ingredient> ingredients = new List<Ingredient>();
  public int orderNumber;
  public int price;
  public int timeElapsed;

  // Iterate through each ingredient in the list and compare it to the drink's ingredients
  // Return false if any ingredient does not match
  public bool checkIngredients(Drink drink)
  {
    for (int i = 0; i < ingredients.Count; i++)
    {
      // Check if the ingredient types match (e.g., Shot, Milk, etc.)
      if (ingredients[i].ingredientType != drink.ingredients[i].ingredientType)
      {
        // TODO: Check if the ingredient is an exact match (e.g., Matcha, Hojicha, etc.)
        Debug.Log("Wrong ingredient order!");
        return false;
      }
    }
    return true;
  }

  public Order(int orderNumber, List<Ingredient> ingredients, int price)
  {
    this.orderNumber = orderNumber;
    this.ingredients = ingredients;
    this.price = price;
    this.timeElapsed = 0;
  }

}