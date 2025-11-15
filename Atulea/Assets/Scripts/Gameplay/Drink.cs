using UnityEngine;
using System.Collections.Generic;

// Drink Controller
// Track and update ingredients in drink
public class Drink
{
  public List<Ingredient> ingredients = new List<Ingredient>();
  public string drinkName;

  public void addIngredient(Ingredient ingredient)
  {
    ingredients.Add(ingredient);
  }

  public void addIngredients(Ingredient[] ingredients)
  {
    this.ingredients.AddRange(ingredients);
  }

  public Ingredient getIngredient(int index)
  {
    return ingredients[index];
  }

  public bool isColdDrink() // Hack, can refactor this later. We aren't even enforcing cup must be first ingredient yet
    {
      return ingredients[0].name.Contains("Cold");
    }
}
