using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "Shot", menuName = "Scriptable Objects/Shot")]
public class Shot : Ingredient
{
    public ShotType shotType;

    public enum ShotType
    {
        Espresso,
        Matcha,
        Hojicha
    }

    public Shot(ShotType shotType = ShotType.Espresso) : base(shotType) { }
    public override IngredientType getType()
    {
        return IngredientType.Shot;
    }
}



