using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionWithMonster : MonoBehaviour
{
    public SoundController sounds;

    void OnCollisionEnter2D(Collision2D c)
    {


        if (c.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            sounds.lvlup.Play();
            LifeController.lebenValue += 1;

        }
    }
}