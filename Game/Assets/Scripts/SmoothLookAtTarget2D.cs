using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothLookAtTarget2D : MonoBehaviour
{

    public GameObject player;
    public GameObject Companion;
    public float DistanceP;
    public float DistanceC;
    public float Range;
    Transform Currentpos;
    Transform transformP;
    Transform transformC;
    public Transform target;
    public float smoothing = 5.0f;
    public float adjustmentAngle = 0.0f;


    // Use this for initialization
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        Companion = GameObject.FindWithTag("Companion");

        Currentpos = GetComponent<Transform>();
        transformP = player.transform;
        transformC = Companion.transform;
    }

    // Update is called once per frame
    private void Update()
    {
        DistanceP = Vector3.Distance(Currentpos.position, transformP.position);
        DistanceC = Vector3.Distance(Currentpos.position, transformC.position);
        if (player != null || Companion != null)
        {
            if (DistanceP > DistanceC)
            {
                Vector3 difference = transformC.position - transform.position;

                //float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;

                Quaternion newRot = Quaternion.Euler(new Vector3(0.0f, 0.0f));

                transform.rotation = Quaternion.Lerp(transform.rotation, newRot, Time.deltaTime * smoothing);
            }
            else if (DistanceC > DistanceP)
            {
                Vector3 difference = transformP.position - transform.position;

                //float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;

                Quaternion newRot = Quaternion.Euler(new Vector3(0.0f, 0.0f));

                transform.rotation = Quaternion.Lerp(transform.rotation, newRot, Time.deltaTime * smoothing);

            }
        }
    }

    public void SetTarget(Transform newTarget)
    {
        target = newTarget;
    }
}
