using UnityEngine;
using UnityEngine.UI;

// Trigger animation and espresso spawning on click
// TODO: extend to steam milk when dragged onto it?
public class EspressoMachineController : MonoBehaviour
{
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        if (anim == null)
        {
            Debug.LogError("Animator component not found on this GameObject.");
        }
    }

    void OnMouseDown() // This function is called when the mouse button is pressed over this collider.
    {
        if (anim != null)
        {
            anim.SetBool("Brew", true); // Trigger the animation
        }
        // TODO: Disable hover highlight while animation is running
        // TODO: spawn draggable shot object
    }

    // Player takes shot from work zone
    public void TakeShot()
    {
        if (anim != null)
        {
            anim.SetBool("Brew", false); // Is there a better way to reset this? Trigger doesn't seem to work correctly so need to use bool for now
            anim.SetBool("TakeShot", true);
        }
    }
}