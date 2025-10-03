using UnityEngine;
using System.Collections.Generic;
using System.Linq;

#if UNITY_EDITOR
using UnityEditor;
#endif

[CreateAssetMenu]
public class IngredientComboDB : ScriptableObject
{
	[SerializeField] IngredientCombination[] combos;

    // TODO: add function to fetch correct combo based on given ingredients

	public IngredientCombination GetComboReference(string comboID)
	{
		foreach (IngredientCombination combo in combos)
		{
			if (combo.ID == comboID)
			{
				return combo;
			}
		}
		return null;
	}

	public IngredientCombination GetComboCopy(string comboID)
	{
		IngredientCombination combo = GetComboReference(comboID);
		return combo != null ? combo.GetCopy() : null;
	}

	public IngredientCombination GetComboFromIndex(int index)
	{
		IngredientCombination combo = combos[index];
		return combo != null ? combo.GetCopy() : null;
	}

#if UNITY_EDITOR
	private void OnValidate()
	{
		LoadItems();
	}

	private void LoadItems()
	{
		combos = FindAssetsByType<IngredientCombination>("Assets/Drinks/Combinations");
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
}
