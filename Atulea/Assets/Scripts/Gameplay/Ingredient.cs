using UnityEngine;
// Abstract class for which ingredients extend (e.g., different shots, milks, etc.)
public abstract class Ingredient
{
  // The general type of ingredient (e.g., Shot, Milk, etc.)
  [HideInInspector] public IngredientType ingredientType;
  // The specific type of general type of ingredient (e.g., Matcha, Hojicha for Shot; Oat, Almond for Milk, etc.)
  public object specificType;

  public enum IngredientType
  {
    Shot,
    Milk,
    Cream,
    Ice,
    Jam,
    Topping
  }

  // This method sets the type for ingredientType and specificType
  public abstract object getType();

  // When an ingredient is created, call getType to set its types
  public Ingredient()
  {
    specificType = getType();
  }
}
