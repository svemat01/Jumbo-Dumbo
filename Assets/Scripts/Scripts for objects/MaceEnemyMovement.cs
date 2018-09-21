using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaceEnemyMovement : MonoBehaviour {

    public float maxMoveDistance = 10;
    //Set this to your objects initial position when game starts.
    Vector3 origin;
    public Vector3 destination;
    public float speed = 10;
    bool Up = true;

    public bool rotate;

    //Refrence to GameManager
    GameObject gamemanager;

    float time = 0;

    void Start()
    {
        gamemanager = GameObject.Find("GameManager");
        origin = transform.position;
        Debug.Log(transform.position);
        StartCoroutine(GoDown());
    }

    IEnumerator GoDown()
    {
        
        yield return new WaitForSecondsRealtime(1);
        transform.position = Vector3.MoveTowards(transform.position, destination, speed * Time.deltaTime);

    }

    IEnumerator GoUp()
    {
        Debug.Log("up");
        time = 5;
        while (time > 0)
        {
            transform.position = Vector3.MoveTowards(transform.position, origin, speed * Time.deltaTime);
        }
        yield return new WaitForSecondsRealtime(5);
        time = 0;
        StartCoroutine(GoDown());
    }

    void Update()
    {
        if (transform.position == origin)
        {
            Up = true;
        } else if (transform.position == destination)
        {
            Up = false;
        }


        if (Up == true)
        {
            StartCoroutine(GoDown());
        }
        if (Up == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, origin, speed * Time.deltaTime);
        }

        if (rotate == true) {
            transform.Rotate(0, 0, -5);
        }
    }

    //Respawn player on collision
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gamemanager.GetComponent<GameManager>().Respawnbutton(true);
        }
    }
}
