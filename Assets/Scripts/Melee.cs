using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Melee : MonoBehaviour {

    private bool isswing = false;
    public int damage = 2;
    public float swingdelay = 4f;
    public float speed = 5.0f;

    Transform enemy;



    private void Setswing()
    {
        isswing = false;
        GetComponent<Collider2D>().enabled = false;
    } 

    private void Attack()
    {
        isswing = true;
        GetComponent<Collider2D>().enabled = true;
        Invoke("Setswing", swingdelay);
    }
    // Use this for initialization
    void Start () {
        GetComponent<Collider2D>().enabled = false;
    }


    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        enemy = collision.transform;
        // apply damage to enemy hit
        //print(collision.transform);
        enemy.SendMessage("TakeDamage", damage);
        //Vector3 facing = -enemy.up;

        
        //if (enemy.GetComponent<Rigidbody2D>().velocity == Vector2.zero)
        //{
            //enemy.GetComponent<Rigidbody2D>().AddForce(facing * 500);
            enemy.SendMessage("DoKnockBack");
        
        //}
        

        //Invoke("Stopknockback", 0.5f);
        
        
        
        //Vector3.MoveTowards(Currentpos.position, collision.transform.position, speed);
    }

    //private void Stopknockback()
    //{
    //    if (enemy != null)
    //    {
    //        enemy.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
    //    }
    //    //print("stop knock back");
    //}

    // Update is called once per frame
    void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!isswing)
            {
                Attack();
            }
        }
	}
}
