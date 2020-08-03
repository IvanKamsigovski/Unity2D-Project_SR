using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject asteroid1;
    public GameObject [] spawnPoints;

    private float spawnTimer = 0f;
    public float spawnRate ;

    void Update()
    {
        spawner();
    }

    void spawner()
    {
        int rand = Random.Range(0, 7);

        if (Time.time >= spawnTimer)
        {
            spawnTimer = Time.time + spawnRate;

            for (int i = 0; i < spawnPoints.Length; i++)
            {
                if(i == rand)
                {
                    Instantiate(asteroid1, spawnPoints[i].transform.position, Quaternion.identity);
                }
            }
        }
    }
}
