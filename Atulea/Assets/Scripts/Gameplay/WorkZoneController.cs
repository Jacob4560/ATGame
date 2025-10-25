using JetBrains.Annotations;
using UnityEngine;

public class WorkZoneController : MonoBehaviour, IDropArea
{
    private Drink workingDrink;
    private GameObject drinkObject;
    private int ingredientCount = 0;

    void Start()
    {
        workingDrink = new();
        drinkObject = new();
        drinkObject.transform.SetParent(transform);
        drinkObject.transform.localPosition = new Vector3(0, 0, 0);
        drinkObject.name = "Working Drink";
    }   
    public void OnItemDrop(Draggable obj)
    {
        if (obj.GetComponent<IngredientSource>() != null)
        {
            IngredientSource source = obj.GetComponent<IngredientSource>();
            workingDrink.addIngredient(source.GetIngredient());
            Debug.Log("Ingredient: " + source.GetIngredient());
            DrinkSpriteConstructor.AddSpriteToDrink(drinkObject, source.GetIngredient(), ++ingredientCount);
        } else
        {
            obj.transform.position = transform.position;
            Debug.Log("Item added to work area");
        }
    }
}
