using UnityEngine;

public class FlotteMove : MonoBehaviour
{
    private bool moveToRight = true;
    public float speed;
    private int dirrection = 1;
    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        transform.position = transform.position + new Vector3(dirrection, 0) * speed * Time.fixedDeltaTime;     
    }
    public void TurnMove()
    {
        transform.position = transform.position + new Vector3(transform.position.x, -5) * Time.fixedDeltaTime;
        if (moveToRight)
        {
            moveToRight = false;
            dirrection = -1;
        }
        else
        {
            moveToRight = true;
            dirrection = 1;
        }
    }
}
