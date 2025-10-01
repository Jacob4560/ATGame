using UnityEngine;
using System.Collections.Generic;
using System;

public class Order
{
  // List of ingredients for the order, checked against the provided drink
  public Drink drink = new Drink();
  public int orderNumber;
  public int price;
  public int timeElapsed;

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
        Debug.Log("Ingredient mismatch at index " + i);
        return false;
      }
    }
    return true;
  }

  public Order(int orderNumber, Drink drink, int price)
  {
    this.orderNumber = orderNumber;
    this.drink = drink;
    this.price = price;
    this.timeElapsed = 0;
  }

}