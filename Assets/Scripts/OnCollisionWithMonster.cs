using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionWithPlayer : MonoBehaviour {
    public SoundController sounds;

    void OnCollisionEnter2D(Collision2D c)
    {
        

        if (c.gameObject.tag == "Wall" && c.gameObject.tag == "Life")
            {
                Destroy(gameObject);
                sounds.alarm.Play();
                LifeController.lebenValue -= 1;
              
            }
        }
    }


