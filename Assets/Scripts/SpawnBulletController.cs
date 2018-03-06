using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBulletController : MonoBehaviour {
    public GameObject bullet;
    public float interval = 1;
	// Use this for initialization
	void Start () 
    {

        InvokeRepeating("shootBullet", interval, interval );
		
	}

    void shootBullet()
    {

        if (bullet != null)
        {
            
            GameObject g = (GameObject)Instantiate(bullet, transform.position, Quaternion.identity);

            }
    }
}
