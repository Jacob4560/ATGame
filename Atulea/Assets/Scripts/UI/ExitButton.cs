using UnityEngine;
using UnityEngine.UI;

public class ExitButton : MonoBehaviour
{
    public Button ExitButtonComponent;
    public GameObject[] ComponentToDisable;
    void Start()
    {
        foreach (var component in ComponentToDisable)
        {
            ExitButtonComponent.onClick.AddListener(() => 
            {
                component.SetActive(!component.activeSelf);
            });
        }
    }
}
