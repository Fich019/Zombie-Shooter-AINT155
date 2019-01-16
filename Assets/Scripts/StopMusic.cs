using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopMusic : MonoBehaviour {

    AudioSource StopMus;
	// Use this for initialization
	void Start () {
        StopMus = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            StopMus.Stop();
        }
    }
}
