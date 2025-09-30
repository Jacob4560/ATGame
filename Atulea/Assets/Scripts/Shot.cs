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
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public override object getType()
    {
        ingredientType = IngredientType.Shot;
        return (object)shotType;
    }
}



