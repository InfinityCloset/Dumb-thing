using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float moveSpeed;

    public Collider2D jumpSensor;

    public float jumpStrength;

    private Rigidbody2D rb;


    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Left & Right Movement
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * moveSpeed, rb.velocity.y);

        //Jumping
        if ((Input.GetAxis("Vertical") > .1f))
        {
            if ((jumpSensor.IsTouchingLayers(LayerMask.GetMask("Ground"))))
            {
                Vector2 jumpVector = new Vector2(0, jumpStrength);
                rb.AddForce(jumpVector);
            }
        }
    }
}