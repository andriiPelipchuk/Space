using System;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    [SerializeField] GameObject gameOver;
    [SerializeField] GameObject flotte;
    [SerializeField] Score score;
    public Camera camera;
    [Header("Enter Rows and Column Enemies")]
    [SerializeField] int rows;
    [SerializeField] int column;
    private Vector3 spaceMin;
    private Vector3 spaceMax;
    private int differnceNumbs;
    private float requiredValueX;
    private float requiredValueY;
    public List<GameObject> shipArray;

    private void Start()
    {
        CameraView();
    }
    private void Update()
    {
        if (shipArray.Count == 0) 
        {
            SpawnFlotte();
        }

    }

    private void CameraView()
    {
        spaceMin = camera.ViewportToWorldPoint(new Vector3(0, 0));
        spaceMax = camera.ViewportToWorldPoint(new Vector3(1, 1));
        CheckSpaceForEnemies();
        if (requiredValueX < rows || requiredValueY < column)
        {
            print("Value more than necessary, recommended the following value" + requiredValueX + "Rows, " + requiredValueY + "Column");
        }
        else
        {
            differnceNumbs = rows - Mathf.FloorToInt(spaceMin.x);
            differnceNumbs -= rows;
            SpawnFlotte();
        }
    }

    private void CheckSpaceForEnemies()
    {
        requiredValueX = Mathf.Abs(spaceMin.x) + spaceMax.x;
        requiredValueY = 1 + spaceMax.y;
    }

    private void SpawnFlotte()
    {
        for (float x = spaceMin.x + 0.5f; x <= column - differnceNumbs; x++)
        {
            for (float y = -1; y <= rows - 2; y++)
            {
                var ship = Instantiate(enemy, new Vector3(x, y), Quaternion.identity);
                shipArray.Add(ship);
                var enemyHealth = ship.GetComponent<EnemyHealth>();
                enemyHealth.scoreText = score;
                enemyHealth.gameOver = gameOver;
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
        var player = FindObjectOfType<PlayerHealth>();
        player.health += 10;
        var flotteMove = FindObjectOfType<FlotteMove>();
        flotteMove.speed *= 2;
    }
}
