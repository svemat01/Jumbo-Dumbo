using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuLevelButton : MonoBehaviour {
    
    [Header("Level")]
    public int levelNumber;

    public Sprite completed;

	// Use this for initialization
	void Start () {
        PlayerPrefs.SetInt("Level" + "1", 1);
        if (PlayerPrefs.GetInt("Level" + levelNumber.ToString()) == 1)
        {
            GetComponent<Image>().sprite = completed;
            GetComponent<Button>().interactable = true;

        } else {
            GetComponent<Button>().interactable = false;
        }
	}
	

}
