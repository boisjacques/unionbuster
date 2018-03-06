using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayerBullet: MonoBehaviour
{
    public GameObject bullet;
    public float interval = 1;
    public SoundController sounds;
    // Use this for initialization
    void Start()
    {

        InvokeRepeating("shootBullet", interval, interval);

    }

    void shootBullet()
    {

        if (bullet != null)
        {
            sounds.bulletPlayerSound.Play();
            GameObject g = (GameObject)Instantiate(bullet, transform.position, Quaternion.identity);

        }
    }
}
