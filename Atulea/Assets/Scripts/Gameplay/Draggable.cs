using PlasticPipe.PlasticProtocol.Messages;
using UnityEngine;

public class Draggable : MonoBehaviour
{
    private Collider2D col;
    private Vector3 startDragPosition;

    [SerializeField] private bool oneUse = false; // For one use ingredient sources like shots

    private void Start()
    {
        col = GetComponent<Collider2D>();
    }

    private void OnMouseDown()
    {
        startDragPosition = transform.position;
        transform.position = GetMousePositionInWorldSpace();
    }

    private void OnMouseDrag()
    {
        transform.position = GetMousePositionInWorldSpace();
    }

    private void OnMouseUp()
    {
        col.enabled = false;
        Collider2D hitCollider = Physics2D.OverlapPoint(transform.position);
        col.enabled = true;
        if (hitCollider != null && hitCollider.TryGetComponent(out IDropArea dropArea))
        {
            dropArea.OnItemDrop(this);
            if (oneUse) Destroy(gameObject);
        }
        transform.position = startDragPosition;
    }

    public Vector3 GetMousePositionInWorldSpace()
    {
        Vector3 p = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        p.z = 0f;
        return p;
    }
}
