using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardsPlayer : MonoBehaviour
{

    public Transform target;
    public float speed = 5.0f;

    SpriteRenderer spriterender;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * 0.01f);

        }
    }

    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        spriterender = GetComponent<SpriteRenderer>();
        if (x < 0)
        {
            spriterender.flipX = true;

        }
        else if (x > 0)
        {
            spriterender.flipX = false;
        }
    }

}
