using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class IngredientTest
{
  public GameObject obj;
  public Ingredient milk1;
  public Ingredient milk2;

  [SetUp]
  public void Setup()
  {
    // Try default Milk as a test ingredient
    milk1 = new Milk();
    milk2 = new Milk(Milk.MilkType.Oat);
  }

  [Test]
  public void IngredientTestSimplePasses()
  {
    // Check that the default ingredient has the correct types
    Assert.AreEqual(Ingredient.IngredientType.Milk, milk1.ingredientType);
    Assert.AreEqual(Milk.MilkType.Whole, milk1.specificType);
    // Check that the oat milk ingredient has the correct types
    Assert.AreEqual(Ingredient.IngredientType.Milk, milk2.ingredientType);
    Assert.AreEqual(Milk.MilkType.Oat, milk2.specificType);
  }

}
