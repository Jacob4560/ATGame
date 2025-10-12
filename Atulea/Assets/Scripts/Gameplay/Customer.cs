using UnityEngine;

public class Customer : MonoBehaviour
{
    [SerializeField] public Order order;
    void Start()
    {
        // Move to position
        // Make order
    }

    public void AcceptOrder(Drink drink) // TODO: extend to multiple drinks in order?
    {
        // Check if given drink(s) match order
        // If correct spawn money/points/trash and animate to leave
        // Else angry react? Reduce patience meter or money or just have them leace

    }

}