using JetBrains.Annotations;
using UnityEngine;

public class WorkZoneController : MonoBehaviour, IDropArea
{
    public void OnItemDrop(Draggable obj)
    {
        obj.transform.position = transform.position;
        Debug.Log("Item added to work area");
    }
}
