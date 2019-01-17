using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompainionHealth : MonoBehaviour {

    public delegate void UpdateHealth(int newHealth);
    public static event UpdateHealth OnUpdateHealth;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SendHealthData(int health)
    {
        if (OnUpdateHealth != null)
        {
            OnUpdateHealth(health);
        }
    }
}
