using UnityEngine;

public class BlockHealth : MonoBehaviour
{
    private int health = 30;
    private int damage = 10;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Projectile")
        {
            health -= damage;
            if (health <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
