using UnityEngine;

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
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public override IngredientType getType()
    {
        ingredientType = IngredientType.Shot;
        return ingredientType;
    }
}



