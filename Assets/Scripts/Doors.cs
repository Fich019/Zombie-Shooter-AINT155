using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour {

    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject enemy4;
    public GameObject enemy5;
    public GameObject enemy6;
    public GameObject enemy7;
    public GameObject door;
    public Transform target;
    private bool shouldMove;
    Collider2D collider;
    //Animator animator;
    AudioSource doorAC;
    bool doorOpened;


    // Use this for initialization
    void Start()
    {
        collider = GetComponent<Collider2D>();
        collider.enabled = true;
        door = GameObject.FindGameObjectWithTag("door");
        doorAC = GetComponent<AudioSource>();
        doorOpened = false;
    }

    // Update is called once per frame
    void Update()
    {
        disableDoors();
    }

    void disableDoors()
    {
        if (enemy1 == null && enemy2 == null && enemy3 == null && enemy4 == null
            && enemy5 == null && enemy6 == null && enemy7 == null)
        {
            collider.enabled = false;
            door.SetActive(false);
            //move doors along x to open 
            if (doorOpened != true)
            {
                doorAC.Play();
            }
            doorOpened = true;

        }
        else
        {
            doorOpened = false;
        }


    }
}
