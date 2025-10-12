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
        customer = Instantiate(customerPrefab, GetComponentInParent<Transform>());
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
