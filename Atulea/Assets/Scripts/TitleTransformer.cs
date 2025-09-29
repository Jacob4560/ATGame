using UnityEngine;

public class TitleTransformer : MonoBehaviour
{
  public GameObject target;
  public float maxAngle;
  public float frequency;
  public float scale;
  void Update()
  {
    target.transform.rotation = Quaternion.Euler(
      0,
      0,
      Mathf.Sin(frequency * Time.time) * maxAngle
    );
    target.transform.localScale = Vector3.one * (1 + ((Mathf.Abs(Mathf.Sin(frequency * Time.time)) * scale) / 2));
  }
}
