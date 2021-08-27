using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    [SerializeField] GameObject flotte;
    [SerializeField] Score score;
    private void Start()
    {
        for(float x = -2.4f; x <= 2.4f ;x += 0.7f)
        {
            for(float y = 0; y <= 3.5f; y+= 0.5f)
            {
                var ship = Instantiate(enemy, new Vector3(x, y), Quaternion.identity);
                var enemyHealth = ship.GetComponent<EnemyHealth>();
                enemyHealth.scoreText = score;
                if (y >= 2)
                {
                    enemyHealth.healthEnemy = 20;
                }
                else
                {
                    enemyHealth.healthEnemy = 10;
                }
                ship.transform.SetParent(flotte.transform);
            }
        }
    }
}
