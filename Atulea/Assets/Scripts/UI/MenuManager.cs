using UnityEngine;

/*
* Menu Manager
* ~~~~~~~~~~~~~
* Controls overall Main Menu logic for switching between panels 
*/
public class MenuManager : MonoBehaviour
{
    [SerializeField] SceneFader sceneFader;

    [Header("-------------Menu Panels-------------")]
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject rewardsMenu;
    [SerializeField] private GameObject settingsMenu;

    [Header("-------------Audio-------------")]
    [SerializeField] private AudioManager audioManager;

    void Start()
    {
        sceneFader.gameObject.SetActive(true);
        Debug.Log("Starting game main menu");
        GameObject menu = Instantiate(mainMenu, GameObject.FindGameObjectWithTag("Canvas").transform.position, GameObject.FindGameObjectWithTag("Canvas").transform.rotation, GameObject.FindGameObjectWithTag("Canvas").transform);
    }

    public void BackToMainMenu(string Tag)
    {
        Destroy(GameObject.FindGameObjectWithTag(Tag));
        GameObject menu = Instantiate(mainMenu, GameObject.FindGameObjectWithTag("Canvas").transform.position, GameObject.FindGameObjectWithTag("Canvas").transform.rotation, GameObject.FindGameObjectWithTag("Canvas").transform);
    }

    public void SettingsMenu()
    {
        Destroy(GameObject.FindGameObjectWithTag("Panel_MainMenu"));
        GameObject menu = Instantiate(settingsMenu, GameObject.FindGameObjectWithTag("Canvas").transform.position, GameObject.FindGameObjectWithTag("Canvas").transform.rotation, GameObject.FindGameObjectWithTag("Canvas").transform);
    }

    public void RewardsMenu()
    {
        Destroy(GameObject.FindGameObjectWithTag("Panel_MainMenu"));
        GameObject menu = Instantiate(rewardsMenu, GameObject.FindGameObjectWithTag("Canvas").transform.position, GameObject.FindGameObjectWithTag("Canvas").transform.rotation, GameObject.FindGameObjectWithTag("Canvas").transform);
    }

    public void LoadScene(int buildNum)
    {
        sceneFader.LoadScene(buildNum);
    }
}