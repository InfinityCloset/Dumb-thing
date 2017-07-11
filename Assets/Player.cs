using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float moveSpeed;

    public float jumpStrength;

    private Rigidbody2D rb;


    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        //left & Right movement
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * moveSpeed, rb.velocity.y);

        //jumping
        if (Input.GetAxis("Vertical") > .5f)
        {
            Vector2 jumpVector = new Vector2(0, jumpStrength);
            rb.AddForce(jumpVector);
        }
	}
}
