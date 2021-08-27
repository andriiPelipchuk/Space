using UnityEngine;

public class Projectile : MonoBehaviour
{
    private int speed = 3;
    private void Update()
    {
        transform.position = transform.position + transform.up * speed * Time.deltaTime;
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
