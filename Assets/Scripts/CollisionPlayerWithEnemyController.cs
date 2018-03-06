using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionPlayerWithEnemyController : MonoBehaviour
{
    public SoundController sounds;
    private void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.tag == "Life")
        {
            Destroy(c.gameObject);
            sounds.lvlup.Play();
            LifeController.lebenValue += 1;
        }

    
        if (c.gameObject.tag == "Monster" && LifeController.lebenValue > 1)
        {
            Destroy(c.gameObject);

            LifeController.lebenValue -= 1;

        }
       
        else{
            if (c.gameObject.tag == "Monster" && LifeController.lebenValue ==1)
            {
                
                LifeController.lebenValue -= 1;
                SceneManager.LoadScene("GameOver");
            }
        }
    }
}
