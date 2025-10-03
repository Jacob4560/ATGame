using UnityEngine;

[CreateAssetMenu]
public class Recipe : IngredientCombination
{
    public int Points; // ? drinks might just all be worth the same idk, or this could be how much money it is

    public string DrinkName;

    // TODO: add some rarity for spawn rates? Or gating on levels as you unlock more ingredients?
}
