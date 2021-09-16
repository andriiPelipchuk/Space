using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public GameObject gameOver;
    public Score scoreText;
    public int healthEnemy;
    private int damage = 10;
    private int points;
    private void Start()
    {
        points = healthEnemy;
    }
    private void Update()
    {
        if(transform.position.y <= -4.5f)
        {
            gameOver.SetActive(true);
            Time.timeScale = 0;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Projectile")
        {
            healthEnemy -= damage;
            if (healthEnemy <= 0)
            {
                var ship = FindObjectOfType<SpawnEnemy>();
                CheckShip(ship);
                scoreText.NewScore(points);
                Destroy(gameObject);
            }
        }
    }
    private void CheckShip(SpawnEnemy ship)
    {
        for(int i = 0; i < ship.shipArray.Count; i++)
        {
            if(gameObject == ship.shipArray[i])
            {
                ship.shipArray.Remove(gameObject);
            }
        }
    }
}
