using UnityEngine;

public class Player : MonoBehaviour
{
    public float xInput;
    public Rigidbody2D rb;

    private void Update()
    {
        xInput = Input.GetAxisRaw("Horizontal");

        rb.linearVelocity = new Vector2(xInput, rb.linearVelocity.y);
    }
    //public float moveSpeed = 5f;
    //public float jumpForce = 10f;

    //public Rigidbody2D rb;

    //// Start is called once before the first execution of Update after the MonoBehaviour is created
    //void Start()
    //{
    //    rb = GetComponent<Rigidbody2D>();
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    float moveInput = Input.GetAxis("horizontal");
    //    rb.linearVelocity = new Vector2(moveInput * moveSpeed, rb.linearVelocity.y);

    //    if (Input.GetKeyDown(KeyCode.Space))
    //    {
    //        rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
    //    }
    //}
}
