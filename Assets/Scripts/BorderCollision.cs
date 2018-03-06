using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderCollision : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.tag != "Player" && c.gameObject.tag != "PlayerBullet")
        {
            Destroy(c.gameObject);
        }

    }
}