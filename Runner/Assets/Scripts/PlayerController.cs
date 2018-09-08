using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float moveSpeed;
    public float jumpSpeed;

    private Rigidbody2D rb;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool grounded;

	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}

    void FixedUpdate() {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
    }

    void Update () {
        rb.velocity = new Vector2(moveSpeed, rb.velocity.y);

        if(Input.GetMouseButton(0) && grounded)
            rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
	}
}
