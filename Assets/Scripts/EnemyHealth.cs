using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public Score scoreText;
    public int healthEnemy;
    private int damage = 10;
    private int points;
    private void Start()
    {

        points = healthEnemy;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Projectile")
        {
            healthEnemy -= damage;
            if (healthEnemy <= 0)
            {
                scoreText.NewScore(points);
                Destroy(gameObject);
            }
        }
    }
}
