using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject asteroid1;
    public GameObject powerUp;
    public GameObject [] spawnPoints;
    public GameObject powerUpSpawn;

    public float spawnRate = 0;

    public float powerupSpawnerRate = 5f;

    private float powerUpTimer;
    private float spawnTimer;

    void Update()
    {
       spawnAsteroid();
       //spawnPowerUp();
    }



    void spawnAsteroid()
    {
        int rand = Random.Range(0, 7);

        if (Time.time >= spawnTimer)
        {
            spawnTimer = Time.time + spawnRate;
            for (int i = 0; i < spawnPoints.Length; i++)
            {
                if (i == rand)
                {
                    Instantiate(asteroid1, spawnPoints[i].transform.position, Quaternion.identity);
                }
            }
        }
    }

    void spawnPowerUp()
    {
        int rand = Random.Range(0, 3);

        if (Time.time >= powerUpTimer)
        {
            powerUpTimer = Time.time + powerupSpawnerRate;
            //Instantiate(powerUp, powerUpSpawn.transform.position, Quaternion.identity);
              switch (rand)
              {
                  case 0:
                      {
                          Instantiate(powerUp, powerUpSpawn.transform.position, Quaternion.identity);
                      }
                      break;
                  case 1:
                      {
                          Instantiate(powerUp, new Vector2(2, 7), Quaternion.identity);
                      }
                      break;
                  case 2:
                      {
                          Instantiate(powerUp, new Vector2(-2, 7), Quaternion.identity);
                      }
                      break;
                  default:
                      Instantiate(powerUp, powerUpSpawn.transform.position, Quaternion.identity);
                      break;
              }
        }
    }
}
