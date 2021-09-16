using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody rb;
    private int speed = 3;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        var horizontal = Input.GetAxis("Horizontal");
        if (horizontal > 0 || horizontal < 0)
            rb.MovePosition(transform.position + new Vector3(horizontal, 0) * speed * Time.fixedDeltaTime);
    }
}
