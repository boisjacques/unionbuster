using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CollisionMonsterBullet : MonoBehaviour
{
    


  public void OnCollisionEnter2D(Collision2D c)

    {
        if (c.gameObject.tag == "Player")
        {
           
            LifeController.lebenValue -= 1;
        }

        if (c.gameObject.tag == "Monster" || c.gameObject.tag == "Bullet" || c.gameObject.tag == "Life")
        {
            Physics2D.IgnoreCollision(c.transform.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
        else
        {
            if (gameObject.tag == "Player" && LifeController.lebenValue > 1)
            {

                LifeController.lebenValue -= 1;
            }
            if (gameObject.tag == "Player" && LifeController.lebenValue <= 1)
            {

                LifeController.lebenValue -= 1;
                SceneManager.LoadScene("GameOver");
            }


            if (c.gameObject.tag != "Wall" || c.gameObject.tag != "Player")
            {
                Destroy(c.gameObject);

            }
            if (c.gameObject.tag == "Wall")
            {
                Destroy(gameObject);

            }
        }
    }
}