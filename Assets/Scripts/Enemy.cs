using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class EnemySpawnedEvent : UnityEvent<Transform> { }


public class Enemy : MonoBehaviour {

    public EnemySpawnedEvent onSpawn;


	// Use this for initialization
	void Start () {
        GameObject player = GameObject.FindWithTag("Player");
        onSpawn.Invoke(player.transform);
        
	}
	
    public void DoKnockBack()
    {
        GetComponent<Rigidbody2D>().AddForce(-transform.up * 7, ForceMode2D.Impulse);
        GetComponent<MoveTowardsObject>().enabled = false;
        Invoke("Stopknockback", 1);
    }
    private void Stopknockback()
    {
       GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        GetComponent<MoveTowardsObject>().enabled = true;
        print("stop knock back");
    }

    // Update is called once per frame
    void Update () {
		
	}
}
