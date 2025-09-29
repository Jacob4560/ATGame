using UnityEngine;

public class Shot : Ingredient
{
    public ShotType shotType;

    public enum ShotType
    {
        Espresso,
        Matcha,
        Hojicha
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        switch (shotType)
        {
            case ShotType.Espresso:
                spriteRenderer.sprite = Resources.Load<Sprite>("Sprites/espresso_shot");
                break;
            case ShotType.Matcha:
                spriteRenderer.sprite = Resources.Load<Sprite>("Sprites/matcha_shot");
                break;
            case ShotType.Hojicha:
                spriteRenderer.sprite = Resources.Load<Sprite>("Sprites/hojicha_shot");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}



