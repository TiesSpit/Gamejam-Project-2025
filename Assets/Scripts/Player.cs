using UnityEngine;

public class Player : MonoBehaviour
{
    private float xInput;
    private Rigidbody2D rb;
    [SerializeField] private float moveSpeed = 6f;
    [SerializeField] private float jumpForce = 20f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        //Player movement
        HandleInput();
        HandleMovement();

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


}
