using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseSmoothLook2D : MonoBehaviour {

    public Camera theCamera;
    public float smoothing = 5.0f;
    public float adjustmentAngle = 0.0f;
    public GameObject Bow;
    SpriteRenderer spriteBow;
    public SpriteRenderer spritePlayer;
    public GameObject bulletSpawnPoint;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 target = theCamera.ScreenToWorldPoint(Input.mousePosition);
        Vector3 difference = target - transform.position;

        difference.Normalize();

        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        Quaternion newRotation = Quaternion.Euler(new Vector3(0.0f, 0.0f, rotZ + adjustmentAngle));
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, Time.deltaTime * smoothing);

        FlipBow();
    }

    void FlipBow()
    {

        //get srpite of gun 
        spriteBow = GetComponent<SpriteRenderer>();

        //check rotation 
        if ((Bow.transform.eulerAngles.z < 270 && Bow.transform.eulerAngles.z > 90))
        {
            //flip image in these conditions
            spriteBow.flipY = true;
            spritePlayer.flipX = true;
            spriteBow.transform.localPosition = new Vector3(0.095f, -0.07f, 0);
            bulletSpawnPoint.transform.localPosition = new Vector3(1f, 0f, 0);
        }
        else
        {
            spriteBow.flipY = false;
            spritePlayer.flipX = false;
            spriteBow.transform.localPosition = new Vector3(-0.095f, -0.07f, 0);
            bulletSpawnPoint.transform.localPosition = new Vector3(1f, -0.149f, 0);
        }
    }
}
