using UnityEngine;
using System.Collections.Generic;

public class Customer : MonoBehaviour
{
    [SerializeField] public Order order;
    // List of possible sprites for this customer
    public List<Sprite> availableSprites;
    public RecipeDB availableRecipes;
    public GameObject speechBubble;
    private TranslateObject translator;
    public float accuracyMultiplier = 1.0f;
    public float speedMultiplier = 1.0f;
    
    void Start()
    {
        // Move to position
        // Make order
        translator = GetComponent<TranslateObject>();
    }

  void Update()
    {
    // This should be an event handler, should fix this later.
    speechBubble.GetComponent<SpriteRenderer>().enabled = false;
    if (translator.isMoving)
    {
        speechBubble.GetComponent<SpeechBubbleManager>().hideSprite();
    } else
    {
        speechBubble.GetComponent<SpeechBubbleManager>().showSprite();
    }
  }

  public void AcceptOrder(Drink drink) // TODO: extend to multiple drinks in order?
    {
        // Check if given drink(s) match order
        // If correct spawn money/points/trash and animate to leave
        // Else angry react? Reduce patience meter or money or just have them leace

    }

    // Sets the customer's skin to a random skin (change sprites in prefab for this to work)
    public void SetRandomSprite()
    {
        GetComponent<SpriteRenderer>().sprite = availableSprites[Random.Range(0, availableSprites.Count)];
    }

    // Sets the target Transform for the customer to translate toward.
    public void SetMovementTarget(Transform target)
    {
        GetComponent<TranslateObject>().target = target;
    }

    public void generateRandomOrder()
    {
        Recipe recipe = availableRecipes.GetRecipeList()[Random.Range(0, availableRecipes.GetRecipeList().Length)];
        order = new Order(recipe);
        speechBubble.GetComponent<SpeechBubbleManager>().itemSprite = recipe.Image;
    }
}