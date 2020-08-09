using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject asteroid1;
    public GameObject powerUp;
    public GameObject [] spawnPoints;
    public GameObject powerUpSpawn;

    public SpriteRenderer rend;
    public Sprite[] spritesArr;

    public float spawnRate = 0;

    void Start()
    {
        StartCoroutine(spawnAsteroid());
        StartCoroutine(spawnPowerUp());
    }

    IEnumerator spawnAsteroid()
    {
        yield return new WaitForSeconds(spawnRate);
        int rand = Random.Range(0, 7);
            for (int i = 0; i < spawnPoints.Length; i++)
            {
                if (i == rand)
                {
                    Instantiate(asteroid1, spawnPoints[i].transform.position, Quaternion.identity);
                }
            }
        StartCoroutine(spawnAsteroid());
    }

    IEnumerator spawnPowerUp()
    {
        float randTimer = Random.Range(20, 60);
        yield return new WaitForSeconds(2);

        int randSprite = Random.Range(0, spritesArr.Length);

        int rand = Random.Range(0, 3);

        switch (rand)
        {
            case 0:
                {
                    Instantiate(powerUp, powerUpSpawn.transform.position, Quaternion.identity);
                    rend.sprite = spritesArr[randSprite];
                }
                break;
            case 1:
                {
                    Instantiate(powerUp, new Vector2(2, 7), Quaternion.identity);
                    rend.sprite = spritesArr[randSprite];
                }
                break;
            case 2:
                {
                    Instantiate(powerUp, new Vector2(-2, 7), Quaternion.identity);
                    rend.sprite = spritesArr[randSprite];
                }
                break;
            default:
                Instantiate(powerUp, powerUpSpawn.transform.position, Quaternion.identity);
                rend.sprite = spritesArr[randSprite];
                break;

        }
        StartCoroutine(spawnPowerUp());
    }
}
