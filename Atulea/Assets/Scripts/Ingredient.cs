using UnityEngine;

public class Ingredient : MonoBehaviour
{
  public IngredientType ingredientType;

  public enum IngredientType
  {
    Shot,
    Milk,
    Ice,
    Jam,
    Topping
    }

}
