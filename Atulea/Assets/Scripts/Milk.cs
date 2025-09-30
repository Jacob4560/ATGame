using UnityEngine;

public class Milk : Ingredient
{
  public MilkType milkType;
  public enum MilkType
  {
    Whole,
    Coconut,
    Soy,
    Almond,
    Oat,
    Banana
  }

   public override object getType()
    {
        ingredientType = IngredientType.Milk;
        return (object)milkType;
    }

}



