using UnityEngine;

public static class DrinkSpriteConstructor
{
    public static GameObject ConstructDrinkSprite(Drink drink)
    {
        GameObject parentDrink =  new();
        foreach (Ingredient ingredient in drink.ingredients)
        {
            AddSpriteToDrink(parentDrink, drink, ingredient);
        }
        return parentDrink;
    }

    public static void AddSpriteToDrink(GameObject drinkObject, Drink drink, Ingredient ingredient, int order = 2)
    {
        GameObject spriteObject = new();
        SpriteRenderer renderer = spriteObject.AddComponent<SpriteRenderer>();
        renderer.sprite = CheckHotOrColdSprite(drink, ingredient);
        renderer.sortingLayerName = "Gameplay";
        renderer.sortingOrder = order;
        spriteObject.transform.SetParent(drinkObject.transform);
        spriteObject.transform.localPosition = new Vector3(0, 0, 0);
    }

    private static Sprite CheckHotOrColdSprite(Drink drink, Ingredient ingredient)
    {
        if (ingredient.ingredientType == Ingredient.IngredientType.Cup)
        {
            return ingredient.name == "EmptyColdCup" ? ingredient.coldSprite : ingredient.hotSprite; // Temp hack ugly, can't really check ingredient source from here easy rn
        } else if (drink.isColdDrink()) {
            return ingredient.coldSprite;
        } else {
            return ingredient.hotSprite;
        }
    }
}
