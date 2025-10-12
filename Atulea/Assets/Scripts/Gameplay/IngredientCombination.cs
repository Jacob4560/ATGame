using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
[CreateAssetMenu(fileName = "IngredientCombination", menuName = "Scriptable Objects/Ingredient Combination")]
public class IngredientCombination : ScriptableObject
{
    // Should be able to lookup image to display based on combination of ingredients
    // Will gate elsewhere whether an ingredient is allowed to be added to a drink (ex can't add without cup)
    public Sprite Image;

    public string ID;

    public Ingredient[] Ingredients;

    public virtual IngredientCombination GetCopy()
	{
		return this;
	}
}
