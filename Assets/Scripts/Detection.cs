using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detection : MonoBehaviour {

    public SmoothLookAtTarget2D lookAt;

    public List<Transform> enemies = new List<Transform>();

	void Start ()
    {
        InvokeRepeating("Shoot", 0, 2);
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(!enemies.Contains(collision.transform))
        {
            enemies.Add(collision.transform);
        }
    }

    void Shoot()
    {
        Transform closest = null;
        float dist = 9999;
        for (int i = 0; i < enemies.Count; i++)
        {
            if (enemies[i] != null)
            {
                if (Vector3.Distance(transform.position, enemies[i].position) < dist)
                {
                    closest = enemies[i];
                    dist = Vector3.Distance(transform.position, enemies[i].position);
                }
            }
        }


        if(closest != null)
        {
            lookAt.target = closest;
        }

    }
}
