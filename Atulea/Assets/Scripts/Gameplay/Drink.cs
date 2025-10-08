using UnityEngine;
using System.Collections.Generic;

// Drink Controller
// Track and update ingredients in drink
public class Drink : MonoBehaviour
{
  [SerializeField] public List<Ingredient> ingredients = new List<Ingredient>();
  [SerializeField] public string drinkName;

  public void addIngredient(Ingredient ingredient)
  {
    ingredients.Add(ingredient);
  }

  public Ingredient getIngredient(int index)
  {
    return ingredients[index];
  }

}
