using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class OrderTest
{
  public Order order;
  public Drink drink;

  [SetUp]
  public void Setup()
  {
    // Create an order #1 with a shot of espresso and oat milk, price $5
    order = new Order(1, new System.Collections.Generic.List<Ingredient> { new Shot(Shot.ShotType.Espresso), new Milk(Milk.MilkType.Oat) }, 5);
    GameObject obj = new GameObject("EmptyObject");
    drink = obj.AddComponent<Drink>();
    drink.addIngredient(new Shot(Shot.ShotType.Espresso));
    drink.addIngredient(new Milk(Milk.MilkType.Oat));
  }

  [Test]
  public void OrderTestSimplePasses()
  {
    // Check that the order has the correct properties
    Assert.AreEqual(1, order.orderNumber);
    Assert.AreEqual(2, order.ingredients.Count);
    Assert.AreEqual(5, order.price);
    Assert.IsTrue(order.checkIngredients(drink));
  }

}
