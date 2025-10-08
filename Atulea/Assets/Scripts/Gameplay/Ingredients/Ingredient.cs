using UnityEngine;

// Scriptable Object for which ingredients extend (e.g., different shots, milks, etc.)
[System.Serializable]
[CreateAssetMenu(fileName = "Ingredient", menuName = "Scriptable Objects/Ingredient")]
public class Ingredient : ScriptableObject
{
  // The general type of ingredient (e.g., Shot, Milk, etc.)
  public IngredientType ingredientType;

  public Sprite sprite;

  public enum IngredientType
  {
    Shot,
    Milk,
    Cream,
    Ice,
    Jam,
    Topping
  }
}
