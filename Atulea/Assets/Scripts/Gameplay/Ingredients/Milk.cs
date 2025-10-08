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

}



