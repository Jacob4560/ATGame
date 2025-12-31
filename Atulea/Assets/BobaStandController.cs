using UnityEngine;
using UnityEngine.UI;

// Trigger animation and espresso spawning on click
public class BobaStandController : MonoBehaviour
{
    private Animator anim;
    private bool isBobaReady = false;

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
    }

    // Player takes boba from work zone
    public void TakeBoba()
    {
        if (anim != null)
        {
            anim.SetBool("Brew", false); // Is there a better way to reset this? Trigger doesn't seem to work correctly so need to use bool for now
            anim.SetBool("TakeBoba", true);
        }

        isBobaReady = false;
    }

    // TODO: if boba dragged away but not added to drink, reset isBobaReady to true
    public void SetBobaReady()
    {
        isBobaReady = true;
    }
}

