using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardsObject : MonoBehaviour {

    public GameObject player;
    public GameObject Companion;
    public Transform target;
    public float DistanceP;

    
    SpriteRenderer spriterender;
    public float DistanceC;
    public float Range;
    Transform Currentpos;
    Transform transformP;
    Transform transformC;
    public float speed = 5.0f;

    public GameObject Sword;
    SpriteRenderer spriteSword;

    // Use this for initialization
    void Start () {

        player = GameObject.FindWithTag("Player");
        Companion = GameObject.FindWithTag("Companion");
        
        Currentpos = GetComponent<Transform>();
        transformP = player.transform;
        transformC = Companion.transform;
    }
	
	// Update is called once per frame
	private void Update () {

        DistanceP = Vector3.Distance(Currentpos.position, transformP.position);
        DistanceC = Vector3.Distance(Currentpos.position, transformC.position);
        if (player != null || Companion != null)
        {
            if (DistanceP > DistanceC)
            {
                Currentpos.position = Vector3.MoveTowards(Currentpos.position, transformC.position, speed * 0.01f);
            }
            else if (DistanceC > DistanceP)
            {
                Currentpos.position = Vector3.MoveTowards(Currentpos.position, transformP.position, speed * 0.01f);
            }
            else
            {
                Currentpos.position = Vector3.MoveTowards(Currentpos.position, transformP.position, speed * 0.01f);
            }
        }
    }

    private void FixedUpdate()
    {
        //float x = Input.GetAxis("Horizontal");
        //float y = Input.GetAxis("Vertical");

        //spriterender = GetComponent<SpriteRenderer>();
        //if (x < 0)
        //{
        //    spriterender.flipX = true;
        //    spriteSword.flipY = true;
        //    spriteSword.transform.localPosition = new Vector3(0.095f, -0.07f, 0);

        //}
        //else if (x > 0)
        //{
        //    spriterender.flipX = false;
        //    spriteSword.flipY = false;
        //    spriteSword.transform.localPosition = new Vector3(-0.095f, -0.07f, 0);
        //}
    }

    public void SetTarget(Transform newTarget)
    {
        target = newTarget;
    }
}
