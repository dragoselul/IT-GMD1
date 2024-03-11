using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f; // Speed of the player movement
    public float jumpForce = 700f; // Jump force
    private Rigidbody2D rb;
    private bool isGrounded;
    private Animator animator;
    private Vector2 moveInput;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        Move();
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            Jump();
        }
    }

    void Move()
    {
        float move = Input.GetAxis("Horizontal"); // Get movement input
        rb.velocity = new Vector2(move * speed, rb.velocity.y);
        animator.SetFloat("XInput", move);
        animator.SetFloat("YInput", move);
    }

    void Jump()
    {
        rb.AddForce(new Vector2(0f, jumpForce));
        isGrounded = false; // Assume we leave the ground when we jump
    }

    // Check if the player is grounded
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}

