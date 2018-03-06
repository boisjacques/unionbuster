using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionPlayerBulletController : MonoBehaviour {


    void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.tag == "Player" || c.gameObject.tag == "Bullet")
        {
            Physics2D.IgnoreCollision(c.transform.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
        else
        {
            Destroy(gameObject);

            if (c.gameObject.tag != "Wall")
            {
                
                ScoreController.scoreValue += 10;
                Destroy(c.gameObject);
            }
        }
    }
}
