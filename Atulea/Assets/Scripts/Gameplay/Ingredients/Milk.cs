using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "Milk", menuName = "Scriptable Objects/Milk")]public class Milk : Ingredient
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

  public Milk(MilkType milkType = MilkType.Whole) : base(milkType) { }
  public override IngredientType getType()
    {
        return IngredientType.Milk;
    }

}



