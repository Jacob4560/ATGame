using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RecipeBodyManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public TextMeshProUGUI RecipeTitle;
    public Image RecipeSprite;
    public Recipe CurrentRecipe;
    public GameObject IngredientsRow;
    public TMP_FontAsset counterFont;
    void OnEnable()
    {
        RecipeTitle.text = CurrentRecipe.DrinkName;
        RecipeSprite.sprite = CurrentRecipe.Image;
        createIngredientListUI();
    }

    void clearIngredients() {
        foreach (Transform child in IngredientsRow.transform)
        {
            Destroy(child.gameObject);
        }
    }


    void createIngredientListUI()
    {
        // Calculate size of ingredient row based on number of ingredients
        clearIngredients();
        int numIngredients = CurrentRecipe.Ingredients.Length;
        int gapSize = 25;
        int blockWidth = 100;
        RectTransform rt = IngredientsRow.GetComponent<RectTransform>();
        int width = (blockWidth * numIngredients) + (gapSize * (numIngredients + 1));
        rt.sizeDelta = new Vector2(width, rt.sizeDelta.y);

        // Create ingredient blocks
        Color blockColor = new Color32(204,185,171,255);
        for (int i = 0; i < numIngredients; i++)
    {
            GameObject ingredientBlock = new GameObject("IngredientBlock_" + i);
            ingredientBlock.transform.SetParent(IngredientsRow.transform);
            RectTransform ingredientRT = ingredientBlock.AddComponent<RectTransform>();
            ingredientRT.sizeDelta = new Vector2(blockWidth, blockWidth);
            ingredientRT.anchoredPosition = new Vector2(gapSize + i * (blockWidth + gapSize) + blockWidth / 2 - width/2, 0);
            
            // Add Image component for background image
            Image ingredientImage = ingredientBlock.AddComponent<Image>();
            ingredientImage.color = blockColor;

            // Add Outline of the box
            Outline outline = ingredientBlock.AddComponent<Outline>();
            outline.effectColor = Color.black;
            outline.effectDistance = new Vector2(3, 3);
            outline.useGraphicAlpha = true;

            // Add counter
            GameObject counterObj = new GameObject("IngredientCounter_" + i);
            counterObj.transform.SetParent(ingredientBlock.transform);
            RectTransform counterRT = counterObj.AddComponent<RectTransform>();
            counterRT.anchorMin = new Vector2(0, 0);
            counterRT.anchorMax = new Vector2(0, 0);
            counterRT.anchoredPosition = new Vector2(15, 15);
            counterRT.sizeDelta = new Vector2(15, 15);
            TextMeshProUGUI counterText = counterObj.AddComponent<TextMeshProUGUI>();
            counterText.text = (i+1).ToString();
            counterText.font = counterFont;
            counterText.color = Color.black;
            counterText.enableAutoSizing = true;
            // Add Image component for ingredient sprite
            GameObject ingredientSpriteObj = new GameObject("IngredientSprite_" + i);
            ingredientSpriteObj.transform.SetParent(ingredientBlock.transform);
            RectTransform ingredientSpriteRT = ingredientSpriteObj.AddComponent<RectTransform>();
            ingredientSpriteRT.sizeDelta = new Vector2(blockWidth - 20, blockWidth - 20);
            ingredientSpriteRT.anchoredPosition = new Vector2(0, 0);
            Image ingredientSpriteImage = ingredientSpriteObj.AddComponent<Image>();    
            ingredientSpriteImage.sprite = CurrentRecipe.Ingredients[i].hotSprite;
            ingredientSpriteImage.preserveAspect = true;
    }
    }

}
