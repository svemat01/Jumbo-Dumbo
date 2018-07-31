using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    //Variables
    [Header("Variables")]
    public GameObject player;
    public GameObject gameover;

    [Header("Respawn Position")]
    public Vector3 RespawnPosition;

    [Header("Level")]
    public int levelNumber;

    


    // Use this for initialization
    void Start () {
		
	}

    //toggle buttons
    public void Respawnbutton(bool buttonstoggle)
    {
        //player.GetComponent<CharacterController2D>().enabled = !buttonstoggle;
        gameover.SetActive(buttonstoggle);
        player.GetComponent<PlayerMovement>().enabled = !buttonstoggle;
    }

    // Teleport player to start/checkpoint position
    void Respawn () {
        player.transform.position = RespawnPosition;
        Respawnbutton(false);
	}

    public void LevelComplete() {
        PlayerPrefs.SetInt("Level" + levelNumber.ToString(), 1);
        PlayerPrefs.Save();
        PlayerPrefs.GetInt("Level" + levelNumber.ToString());
    }
}
