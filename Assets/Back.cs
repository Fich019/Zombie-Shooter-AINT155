using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Back : MonoBehaviour {


    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Home();
        }
    }


    public void Home()
    {
        SceneManager.LoadScene(0);
    }
}
