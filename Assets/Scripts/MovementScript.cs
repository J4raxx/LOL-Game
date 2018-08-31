using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour {

    public Vector2 speed = new Vector2(10, 10);
    public Vector2 direction = new Vector2(-1, 0);
    private Vector2 movement;
    private Rigidbody2D rb;

	// Use this for initialization
	void Start() {
        rb = gameObject.GetComponent<Rigidbody2D>();
        rb.bodyType = RigidbodyType2D.Kinematic; 
	}
	
	// Update is called once per frame
	void Update () {
        movement = new Vector2(speed.x * direction.x, speed.y * direction.y);
        rb.velocity = movement;
    }
}
