using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;




public class GameManager : MonoBehaviour {

    // Public Variables
    [Header("Variables")]
    public GameObject player;
    public GameObject gameover;
    public GameObject levelcomplete;
    public Animator sceneanim;

    [Header("Respawn Position")]
    public Vector3 RespawnPosition;

    [Header("Level")]
    public int levelNumber;

    // Private Variables
    AudioSource audioData;

    public static float volume;

    


    // Use this for initialization
    void Start () {
        audioData = GetComponent<AudioSource>();
        audioData.loop = true;
        audioData.Play(0);
        sceneanim.SetBool("open", false);
        PlayerPrefs.SetInt("Level" + "0", 1);
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
        levelcomplete.SetActive(false);
        player.transform.position = RespawnPosition;
        Respawnbutton(false);
	}

    // Set Level as compelete when finished
    public void LevelComplete() {
        StartCoroutine(levelcompletescreen());
        PlayerPrefs.SetInt("Level" + levelNumber.ToString(), 1);
        PlayerPrefs.Save();
        PlayerPrefs.GetInt("Level" + levelNumber.ToString());
    }

    // Load Scene
    public void SceneLoad(int ctl) {
        StartCoroutine(LoadScene(ctl));



    }
    IEnumerator LoadScene(int ctl)
    {
        sceneanim.SetBool("open", true);
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene(ctl);
    }
    IEnumerator levelcompletescreen()
    {
        
        yield return new WaitForSeconds(1f);
        levelcomplete.SetActive(true);
        player.GetComponent<PlayerMovement>().enabled = false;
    }
}
