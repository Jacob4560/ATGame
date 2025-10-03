using UnityEngine;
using UnityEngine.SceneManagement;

/*
* Panel Manager
* ~~~~~~~~~~~~~
* Attached to individual UI panel prefabs.
* Responsible for connecting prefab panel buttons to main game logic  
*/
public class PanelManager : MonoBehaviour
{
    private AudioManager audioManager;

    void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManager>();
    }

    public void NewGameButton()
    {
        Debug.Log("New game");
        audioManager.PlaySFX(audioManager.buttonClick);
        MenuManager manager = GameObject.FindGameObjectWithTag("MenuManager").GetComponent<MenuManager>();
        manager.LoadScene(1);
    }
    public void RewardsButton()
    {
        audioManager.PlaySFX(audioManager.buttonClick);
        MenuManager manager = GameObject.FindGameObjectWithTag("MenuManager").GetComponent<MenuManager>();
        manager.RewardsMenu();
    }

    public void SettingsButton()
    {
        audioManager.PlaySFX(audioManager.buttonClick);
        MenuManager manager = GameObject.FindGameObjectWithTag("MenuManager").GetComponent<MenuManager>();
        manager.SettingsMenu();
    }

    public void BackToMainMenuButton()
    {
        audioManager.PlaySFX(audioManager.buttonClick);
        MenuManager manager = GameObject.FindGameObjectWithTag("MenuManager").GetComponent<MenuManager>();
        manager.BackToMainMenu(gameObject.tag);
    }
}