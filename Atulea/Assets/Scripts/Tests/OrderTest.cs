using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class OrderTest
{
  public Order order;

  public Drink drink;
  public Drink drink2;

  [SetUp]
  public void Setup()
  {
    // Create an order #1 with a shot of espresso and oat milk, price $5

    GameObject obj = new GameObject("EmptyObject");
    drink = new Drink();
    drink.addIngredient(new Shot(Shot.ShotType.Espresso));
    drink.addIngredient(new Milk(Milk.MilkType.Oat));

    GameObject obj2 = new GameObject("EmptyObject");
    drink2 = new Drink();
    drink2.addIngredient(new Shot(Shot.ShotType.Espresso));
    drink2.addIngredient(new Milk(Milk.MilkType.Oat));

    order = new Order(1, drink, 5);
  }

  [Test]
  public void OrderFieldsMatch()
  {
    // Check that the order has the correct properties
    Assert.AreEqual(1, order.orderNumber);
    Assert.AreEqual(2, order.drink.ingredients.Count);
    Assert.AreEqual(5, order.price);
  }

  [Test]
  public void OrderMatchesDrink()
  {
    // Check that the order matches the correct drink
    Assert.IsTrue(order.checkIngredients(drink));
  }

  [Test]
  public void OrderMatchesDrinkCopy()
  {
    // Check that the order matches a different drink object with the same ingredients and order
    Assert.IsTrue(order.checkIngredients(drink2));
  }

  [Test]
  public void OrderDoesNotMatchDifferentDrink()
  {
    // Check that a drink with different ingredients does not return true
    drink2.addIngredient(new Milk(Milk.MilkType.Whole));
    Assert.IsFalse(order.checkIngredients(drink2));
  }
}
