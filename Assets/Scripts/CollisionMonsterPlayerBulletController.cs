using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CollisionMonsterPlayerBulletController : MonoBehaviour {


    void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.tag == "Player" || c.gameObject.tag == "PlayerBullet")
        {
            Physics2D.IgnoreCollision(c.transform.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
        else
        {
            Destroy(gameObject);

            if (c.gameObject.tag != "Wall")
            {
                Destroy(c.gameObject);
                if(c.gameObject.tag == "Bullet")
                {
                    
                    ScoreController.scoreValue += 5;
                }
                else{
                    ScoreController.scoreValue += 10;
                }
            }
        }
    }
}

