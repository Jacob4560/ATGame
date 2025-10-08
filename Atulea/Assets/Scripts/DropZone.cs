using UnityEngine;

// Script to handle areas where dragging and dropping drinks will be allowed 
// (e.g. work zones or placing cups under machines)
public interface IDropArea
{
    // Behavior can be extended to perform different actions on drop
    // i.e. update position, add ingredient to drink already there, toss in trash, etc
    void OnItemDrop(Draggable obj);
}
