using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPlayerController : MonoBehaviour {

    public float speed = 1;

	// Use this for initialization
	void Start () {

        GameObject gaOb = GameObject.FindWithTag("Player");
        Vector3 v3 = (gaOb.transform.position - transform.position).normalized;
        Vector2 v2 = new Vector2(v3.x, v3.y);
        GetComponent<Rigidbody2D>().velocity = v2 * speed;
	}
	
}
