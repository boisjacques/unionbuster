using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour {

    public float speed = 10;
    public static bool hit = false;


   

    private void FixedUpdate()
    {

        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Vector2 dir = new Vector2(h, v);
        GetComponent<Rigidbody2D>().velocity = dir.normalized * speed;



        GetComponent<Animator>().SetBool("isFlyingUp", (v > 0));
        GetComponent<Animator>().SetBool("isFlyingLeft", (h < 0));
        GetComponent<Animator>().SetBool("isFlyingRight", (h > 0));
    }


}
