using UnityEngine;

public class TitleTransformer : MonoBehaviour
{
  public GameObject target;
  public float maxAngle;
  public float frequency;
  public float scale;
  void Update()
  {
    // Rotates the object back and forth between -maxAngle and +maxAngle
    target.transform.rotation = Quaternion.Euler(
      0,
      0,
      Mathf.Sin(frequency * Time.time) * maxAngle
    );
    // Scales the object between 1 and 1 + scale (e.g., scale = 0.5, max out to 1.5)
    target.transform.localScale = Vector3.one * (1 + ((Mathf.Abs(Mathf.Sin(frequency * Time.time)) * scale) / 2));
  }
}
