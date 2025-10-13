using UnityEngine;

public class SpeechBubbleManager : MonoBehaviour
{
    public Sprite itemSprite;
    public GameObject insideSprite;

  void Start()
  {
    setInsideSprite();
  }
  public void setInsideSprite()
  {
    insideSprite.GetComponent<SpriteRenderer>().sprite = itemSprite;
  }

  public void hideSprite()
  {
    GetComponent<SpriteRenderer>().enabled = false;
    insideSprite.GetComponent<SpriteRenderer>().enabled = false;
  }
  
  public void showSprite()
  {
    GetComponent<SpriteRenderer>().enabled = true;
    insideSprite.GetComponent<SpriteRenderer>().enabled = true;
  }
}
