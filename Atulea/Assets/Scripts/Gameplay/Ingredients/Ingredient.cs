using UnityEngine;

// Scriptable Object for which ingredients extend (e.g., different shots, milks, etc.)
[System.Serializable]
// [CreateAssetMenu(fileName = "Ingredient", menuName = "Scriptable Objects/Ingredient")]
public abstract class Ingredient : ScriptableObject
{
  // The general type of ingredient (e.g., Shot, Milk, etc.)
  public IngredientType ingredientType;
  public object specificType;

  public Sprite sprite;

  public enum IngredientType
  {
    Shot,
    Milk,
    Cup,
    Ice
  }

  public abstract IngredientType getType();

  public void setType(object specificType)
  {
    this.specificType = specificType;
  }

  // When an ingredient is created, call getType to set its types
  public Ingredient(object specificType = null)
  {
    this.ingredientType = getType();
    this.specificType = specificType;
  }
}
