using UnityEngine;

public class Player : MonoBehaviour
{
    private float xInput;
    private Rigidbody2D rb;
    [SerializeField] private float moveSpeed = 10f;
    [SerializeField] private float jumpForce = 25f;

    [SerializeField] private bool facingRight = true;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        //Player movement
        HandleInput();
        HandleMovement();
        handleFlip();
    }

    private void HandleInput()
    {
        xInput = Input.GetAxisRaw("Horizontal");

        if (Input.GetKeyDown(KeyCode.Space))
            Jump();
    }

    private void HandleMovement()
    {
        rb.linearVelocity = new Vector2(xInput * moveSpeed, rb.linearVelocity.y);
    }

    private void Jump()
    {
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
    }

    private void handleFlip()
    {
        if (rb.linearVelocity.x >0 && facingRight == false)
            flip();
        else if (rb.linearVelocity.x <0 && facingRight == true) 
            flip();
    }
    private void flip()
    {
        transform.Rotate(0, 180, -68);
        facingRight = !facingRight;
    }

}
