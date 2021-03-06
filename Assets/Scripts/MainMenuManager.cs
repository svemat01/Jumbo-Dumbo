﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour {

    [Header("Windows Variables")]
    public GameObject MainMenu;
    public GameObject Settings;
    public GameObject Levels;
    public GameObject Back;
    public Slider slider;


    public Animator sceneanim;
    public GameObject gamemanager;
    public AudioSource gma;


  

	// Main Menu Buttons
	public void MainMenuWindow() {
        StartCoroutine(mainmenu());

	}
    public void Start()
    {
        //StartCoroutine(mainmenu());
        gamemanager = GameObject.Find("GameManager");

        gma = gamemanager.GetComponent<AudioSource>();
        slider.value = PlayerPrefs.GetFloat("volume");



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

    public void volumechange() {
        gma.volume = slider.value;

        PlayerPrefs.SetFloat("volume", slider.value);
        PlayerPrefs.Save();
    }

    IEnumerator levels()
    {
        Levels.SetActive(true);
        yield return new WaitForSeconds(0.4f);
        MainMenu.SetActive(false);
        Settings.SetActive(false);

    }
    IEnumerator settings()
    {
        Settings.SetActive(true);
        yield return new WaitForSeconds(0.4f);
        MainMenu.SetActive(false);

        Levels.SetActive(false);
    }
    IEnumerator mainmenu()
    {
        MainMenu.SetActive(true);
        yield return new WaitForSeconds(0.4f);

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
