using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    [SerializeField] private float jumpStrength = 2f;
    private Rigidbody2D rb;
    private Animator an;
    private float movementX;
    private float movementY;
    private float stopJumping;
    private bool onGround = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        an = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movement = new Vector2(movementX, rb.velocity.y) * speed;
        rb.velocity = new Vector2(movement.x, rb.velocity.y);
        an.SetFloat("XInput", movementX);

        // Apply gravity
        if (!onGround)
        {
            rb.velocity += Physics2D.gravity * (Time.deltaTime * 1.5f);
        }
    }

    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        movementX = movementVector.x;
    }

    void OnJump()
    {
        if (onGround)
        {
            rb.velocity = new Vector2(movementX, jumpStrength);
        }
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collision is with the floor
        if (collision.gameObject.CompareTag("Platform"))
        {
            rb.velocity = new Vector2(movementX, 0f);
            onGround = true;
        }
    }
    
    private void OnCollisionExit2D(Collision2D collision)
    {
        // Check if the collision is with the floor
        if (collision.gameObject.CompareTag("Platform"))
        {
            onGround = false;
        }
    }
}