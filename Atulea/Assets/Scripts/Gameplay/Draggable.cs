using UnityEngine;

public class Draggable : MonoBehaviour
{
    private bool isDragging = false;
    private Vector3 offset; // Offset between mouse click and object's pivot

    void OnMouseDown()
    {
        isDragging = true;
        // Calculate the offset to prevent snapping to the object's pivot
        offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    void OnMouseUp()
    {
        isDragging = false;
    }

        void Update()
        {
            if (isDragging)
            {
                // Get the current mouse position in world coordinates
                Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                // Apply the offset to maintain the grab position
                transform.position = new Vector3(mousePosition.x + offset.x, mousePosition.y + offset.y, transform.position.z);
            }
        }
}
