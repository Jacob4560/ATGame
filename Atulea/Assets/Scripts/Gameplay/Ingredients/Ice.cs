using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "Ice", menuName = "Scriptable Objects/Ice")]public class Ice : Ingredient
{
  public IceType iceType;
  public enum IceType
  {
    Ice
  }

  public Ice(IceType iceType = IceType.Ice) : base(iceType) { }
  public override IngredientType getType()
    {
        return IngredientType.Ice;
    }

}



