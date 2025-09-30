using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class DrinkTest
{
    public GameObject obj;
    public Drink drink;
    [SetUp]
    public void Setup()
    {
        // This method is called before each test
        obj = new GameObject("EmptyObject");
        drink = obj.AddComponent<Drink>();
        drink.drinkName = "Latte";
        // Add a shot then add milk
        drink.addIngredient(new Shot());
        drink.addIngredient(new Milk());
    }

    // A Test behaves as an ordinary method
    [Test]
    public void DrinkTestSimplePasses()
    {
        // Check that the ingredients were added and are in correct order
        Assert.AreEqual(Ingredient.IngredientType.Shot, drink.getIngredient(0).ingredientType);
        Assert.AreEqual(Ingredient.IngredientType.Milk, drink.getIngredient(1).ingredientType);
        // Check if the drink name is set correctly
        Assert.AreEqual(drink.drinkName, "Latte");
    }

}
