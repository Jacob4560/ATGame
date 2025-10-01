using UnityEngine;
using System.Collections.Generic;
public class Drink
{
  public List<Ingredient> ingredients = new List<Ingredient>();
  public string drinkName;
  public string description;

  public void addIngredient(Ingredient ingredient)
  {
    ingredients.Add(ingredient);
  }

  public Ingredient getIngredient(int index)
  {
    return ingredients[index];
  }

}
