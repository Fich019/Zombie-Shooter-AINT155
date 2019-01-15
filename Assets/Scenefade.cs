using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenefade : MonoBehaviour {

    AudioSource Click;
    public Animator sceneanim;

    private void Start()
    {
        Click = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update () {
		if (Input.GetMouseButtonDown(0)){
            Click.Play();
            FadetoLevel(1);
        }
	}

    public void FadetoLevel (int LevelIndex)
    {
        sceneanim.SetTrigger("FadeIn");
    }

    public void OnFadeComplete()
    {
        SceneManager.LoadScene(1);
    }

}
