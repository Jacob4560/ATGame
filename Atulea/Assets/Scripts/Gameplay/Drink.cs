using UnityEngine;
using System.Collections.Generic;
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
