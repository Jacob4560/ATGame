using UnityEngine;

public class CustomerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject customerPrefab;
    public GameObject timerPrefab;
    public float delayBetweenCustomers;
    private GameObject customer;
    private GameObject timer;

    void Start()
    {
        timer = Instantiate(timerPrefab, GetComponentInParent<Transform>());
        timer.GetComponent<Timer>().doAfterTime(createCustomer, delayBetweenCustomers);
    }
    void createCustomer()
    {
        // Grab the position of the CustomerController GameObject
        Transform parentTransform = GetComponentInParent<Transform>();
        // Create an offset on the X axis (start customer off screen to the left)
        Vector3 offset = new Vector3(-13, 0, 0);
        // Instantiate and place the customer off screen
        customer = Instantiate(customerPrefab, parentTransform.position + offset, Quaternion.identity);
        // Place the movement target of the customer to the position of the CustomerController GameObject
        customer.GetComponent<TranslateObject>().target = parentTransform;
    }

    // Update is called once per frame
    void Update()
    {
        // Create a new customer after delayBetweenCustomers seconds if there isn't one.
        if (customer == null && !timer.GetComponent<Timer>().active)
        {
            timer.GetComponent<Timer>().doAfterTime(createCustomer, delayBetweenCustomers);
        }
        
    }
}
