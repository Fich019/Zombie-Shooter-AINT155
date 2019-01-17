using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gameover : MonoBehaviour {


    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject enemy4;
    public GameObject enemy5;
    public GameObject enemy6;
    public GameObject enemy7;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GameOver();
	}

    void GameOver()
    {
        if(enemy1 == null && enemy2 == null && enemy3 == null && enemy4 == null
            && enemy5 == null && enemy6 == null && enemy7 == null)
        {
            SceneManager.LoadScene(2);
        }
    }
}
