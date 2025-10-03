using UnityEngine;
using System.Collections.Generic;
using System.Linq;

#if UNITY_EDITOR
using UnityEditor;
#endif

[CreateAssetMenu]
public class RecipeDB : ScriptableObject
{
	[SerializeField] Recipe[] recipes;

	public Recipe GetRecipeReference(string recipeID)
	{
		foreach (Recipe recipe in recipes)
		{
			if (recipe.ID == recipeID)
			{
				return recipe;
			}
		}
		return null;
	}

	public Recipe GetRecipeCopy(string recipeID)
	{
		Recipe recipe = GetRecipeReference(recipeID);
		return recipe != null ? recipe.GetCopy() as Recipe : null;
	}

	public Recipe GetRecipeFromIndex(int index)
	{
		Recipe recipe = recipes[index];
		return recipe != null ? recipe.GetCopy() as Recipe : null;
	}

#if UNITY_EDITOR
	private void OnValidate()
	{
		LoadItems();
	}

	private void LoadItems()
	{
		recipes = FindAssetsByType<Recipe>("Assets/Drinks/Recipes");
	}
	public static T[] FindAssetsByType<T>(params string[] folders) where T : Object
	{
		string type = typeof(T).Name;

		string[] guids;
		if (folders == null || folders.Length == 0)
		{
			guids = AssetDatabase.FindAssets("t:" + type);
		}
		else
		{
			guids = AssetDatabase.FindAssets("t:" + type, folders);
		}

		T[] assets = new T[guids.Length];

		for (int i = 0; i < guids.Length; i++)
		{
			string assetPath = AssetDatabase.GUIDToAssetPath(guids[i]);
			assets[i] = AssetDatabase.LoadAssetAtPath<T>(assetPath);
		}
		return assets;
	}
#endif

// TODO: add more complex system here for spawn rates later if needed, can ignore for now
	// private float GetItemSpawnRate(Item.Rarity rarity)
	// {

    //     gameManager = FindFirstObjectByType<GameManager>();
	// 	List<Certificate> playerCerts = gameManager.FetchCertificates();

		
	// 	if (playerCerts.Any(c => c.type == Certificate.CertificateType.SUPPLY_SOURCING))
	// 	{
	// 		return rarity switch
	// 		{
	// 			Item.Rarity.COMMON => 0.3f,
	// 			Item.Rarity.UNCOMMON => 0.4f,
	// 			Item.Rarity.RARE => 0.3f,
	// 			_ => 1f
	// 		};
	// 	}
		
	// 	return rarity switch
	// 	{
	// 		Item.Rarity.COMMON => 0.5f,
	// 		Item.Rarity.UNCOMMON => 0.35f,
	// 		Item.Rarity.RARE => 0.15f,
	// 		_ => 1f
	// 	};
	// }

	private Recipe GetRandomDrinkRecipe()
	{
		// Get total drop chance
		float totalChance = 0f;
		for (int i = 0; i < recipes.Count(); i++)
		{
			totalChance +=  0.2f; //GetItemSpawnRate(recipes[i].recipeRate); // equal rate for now
		}
		float rand = Random.Range(0f, totalChance);
		float cumulativeChance = 0f;
		for (int i = 0; i < recipes.Count(); i++)
		{
			cumulativeChance += 0.2f; // GetItemSpawnRate(itemsToCheck[i].itemRarity);
			if (rand <= cumulativeChance)
			{
				return GetRecipeCopy(recipes[i].ID);
			}
		}
		return GetRecipeCopy(recipes[0].ID);
    }
}
