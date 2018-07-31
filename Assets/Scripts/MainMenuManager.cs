using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuManager : MonoBehaviour {

    [Header("Windows Variables")]
    public GameObject MainMenu;
    public GameObject Settings;
    public GameObject Levels;
    public GameObject Back;

	// Use this for initialization
	public void MainMenuWindow() {
        MainMenu.SetActive(true);
        Settings.SetActive(false);
        Levels.SetActive(false);

	}
	
	// Update is called once per frame
    public void ExitGame()
    {
        
    }

    public void SettingsWindow()
    {
        MainMenu.SetActive(false);
        Settings.SetActive(true);
        Levels.SetActive(false);
    }

    public void LevelsWindow()
    {
        MainMenu.SetActive(false);
        Settings.SetActive(false);
        Levels.SetActive(true);
    }
}
