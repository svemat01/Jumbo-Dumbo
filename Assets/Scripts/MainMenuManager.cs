using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour {

    [Header("Windows Variables")]
    public GameObject MainMenu;
    public GameObject Settings;
    public GameObject Levels;
    public GameObject Back;


    public Animator sceneanim;



  

	// Main Menu Buttons
	public void MainMenuWindow() {
        StartCoroutine(mainmenu());

	}
    public void Start()
    {
        StartCoroutine(mainmenu());

    }
	
    public void ExitGame()
    {
        
    }

    public void SettingsWindow()
    {
        StartCoroutine(settings());
    }

    public void LevelsWindow()
    {
        StartCoroutine(levels());
    }
    IEnumerator levels()
    {
        yield return new WaitForSeconds(0.4f);
        MainMenu.SetActive(false);
        Settings.SetActive(false);
        Levels.SetActive(true);
    }
    IEnumerator settings()
    {
       
        yield return new WaitForSeconds(0.4f);
        MainMenu.SetActive(false);
        Settings.SetActive(true);
        Levels.SetActive(false);
    }
    IEnumerator mainmenu()
    {
        
        yield return new WaitForSeconds(0.4f);
        MainMenu.SetActive(true);
        Settings.SetActive(false);
        Levels.SetActive(false);
    }

    // Settings stuff
    public void restartlevels() {
        //PlayerPrefs.SetInt("Level1", 0);
        //PlayerPrefs.SetInt("Level2", 0);
        //PlayerPrefs.SetInt("Level3", 0);
        //PlayerPrefs.SetInt("Level4", 0);
        //PlayerPrefs.Save();

        for (int i = 0; i < 4; ++i)
        {
            PlayerPrefs.SetInt("Level" + (i + 1), 0);
            Debug.Log((i + 1));
        }

    }
}
