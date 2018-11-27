using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompanionWeapon : MonoBehaviour {

    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public Transform bulletSpawnLeft;

    public float fireTime = 0.5f;

    private bool isFiring = false;

    private void SetFiring()
    {
        isFiring = false;
    }

    public void Fire()
    {
        isFiring = true;
        Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
        Instantiate(bulletPrefab, bulletSpawnLeft.position, bulletSpawnLeft.rotation);

        if (GetComponent<AudioSource>() != null)
        {
            GetComponent<AudioSource>().Play();
        }

        Invoke("SetFiring", fireTime);
    }
   
}
