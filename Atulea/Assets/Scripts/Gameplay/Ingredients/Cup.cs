using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "Cup", menuName = "Scriptable Objects/Cup")]
public class Cup : Ingredient
{
  public CupType cupType;

  public enum CupType
  {
    Small,
    Medium,
    Large,
    Iced
  }

  public Cup(CupType cupType = CupType.Medium) : base(cupType) { }
  public override IngredientType getType()
  {
    return IngredientType.Cup;
  }
}



