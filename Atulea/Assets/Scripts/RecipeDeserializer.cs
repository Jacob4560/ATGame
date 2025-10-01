using UnityEngine;

public static class RecipeDeserializer
{
    public static Drink DeserializeRecipe(string json)
    {
        Drink drink = JsonUtility.FromJson<Drink>(json);
        return drink;
    }
}
