using UnityEngine;

public static class DrinkSpriteConstructor
{
    public static GameObject ConstructDrinkSprite(Drink drink)
    {
        GameObject parentDrink =  new();
        foreach (Ingredient ingredient in drink.ingredients)
        {
            AddSpriteToDrink(parentDrink, ingredient);
        }
        return parentDrink;
    }

    public static void AddSpriteToDrink(GameObject drink, Ingredient ingredient, int order = 2)
    {
        GameObject spriteObject = new();
        SpriteRenderer renderer = spriteObject.AddComponent<SpriteRenderer>();
        renderer.sprite = ingredient.sprite;
        renderer.sortingLayerName = "Gameplay";
        renderer.sortingOrder = order;
        spriteObject.transform.SetParent(drink.transform);
        spriteObject.transform.localPosition = new Vector3(0, 0, 0);
    }
}
