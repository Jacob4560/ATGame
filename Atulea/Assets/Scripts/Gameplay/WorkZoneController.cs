using JetBrains.Annotations;
using UnityEngine;

public class WorkZoneController : MonoBehaviour, IDropArea
{
    private Drink workingDrink = new Drink();
    public void OnItemDrop(Draggable obj)
    {
        if (obj.GetComponent<IngredientSource>() != null)
        {
            IngredientSource source = obj.GetComponent<IngredientSource>();
            workingDrink.addIngredient(source.GetIngredient());
            Debug.Log("Ingredient: " + source.GetIngredient());
        } else
        {
            obj.transform.position = transform.position;
            Debug.Log("Item added to work area");
        }
    }
}
