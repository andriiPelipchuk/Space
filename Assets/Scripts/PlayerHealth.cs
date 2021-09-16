using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] Score score;
    [SerializeField] GameObject gameOver;
    public int health = 30;
    private int damage = 10;
    private Color color;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Projectile")
        {
            health -= damage;
            if (health <= 0)
            {
                score.AddBestScore();
                gameObject.SetActive(false);
                Time.timeScale = 0;
                gameOver.gameObject.SetActive(true);
            }
        }
    }
    public void SpawnPlayer()
    {
        gameOver.gameObject.SetActive(false);
        transform.position = new Vector3(0f, -4.52f);
        gameObject.SetActive(true);
        Time.timeScale = 1;
    }
    public void Red()
    {
        color = Color.red;
        ChangeColor();
    }
    public void Green()
    {
        color = Color.green;
        ChangeColor();
    }
    public void Blue()
    {
        color = Color.blue;
        ChangeColor();
    }
    private void ChangeColor()
    {
        gameObject.GetComponent<MeshRenderer>().material.color = color;
    }
}
