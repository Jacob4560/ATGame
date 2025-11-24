using System;
using UnityEngine;
using TMPro;

public class PointTracker : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int points;
    public GameObject pointDisplay;
    private const int DRINK_VALUE = 10;

    void addPoints(int calculatedPoints)
    {
        points += calculatedPoints;
        updateDisplay();
    }

    void addPoints(Customer customer)
    {
        points += (int)Math.Round(DRINK_VALUE * customer.accuracyMultiplier * customer.speedMultiplier);
        updateDisplay();
    }
    void Start()
    {
        points = 0;
        updateDisplay();
    }

    private void updateDisplay()
    {
        pointDisplay.GetComponent<TextMeshProUGUI>().text = points.ToString();
    }
}
