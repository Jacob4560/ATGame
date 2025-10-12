using UnityEngine;

public class TranslateObject : MonoBehaviour
{
    public Transform target; // Assign the target Transform in the Inspector
    public float speed = 2f;

    void Update()
    {
        float step = speed * Time.deltaTime; // Calculate the distance to move this frame
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    }
}