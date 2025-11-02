using UnityEngine;

// TODO this should probably be replaced with a highlight outline later, but think we would need to create different sprites for that
// For now lighten the whole sprite on hover:
public class HighlightOnHover : MonoBehaviour
{
    private Color startColor;
    private Color highlightColor = new Color (0.9f, 1, 0.9f);
    private SpriteRenderer sprite;

    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    void OnMouseEnter ()
    {
        startColor = sprite.material.color;
        sprite.material.SetColor("_Color", highlightColor);
    }

    void OnMouseExit ()
    {
        sprite.material.color = startColor;
    }
}
