using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] Score score;
    [SerializeField] SpawnEnemy spawnEnemy;
    [SerializeField] GameObject popUp;

    private void Start()
    {
        score.LoadScore();
    }
    public void Pause()
    {
        Time.timeScale = 0;
        popUp.gameObject.SetActive(true);
    }
    public void Play()
    {
        Time.timeScale = 1;
        popUp.gameObject.SetActive(false);
    }
}
