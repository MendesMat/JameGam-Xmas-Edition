using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject Spawner;
    public GameObject Obstacle;

    private float spawnRate = 2f;

    private void Update()
    {
        spawnRate -= Time.deltaTime;
        if (spawnRate <= 0)
        {
            SpawnObstacle();
        }
    }

    void SpawnObstacle()
    {
        Instantiate(Obstacle, new Vector3(Spawner.transform.position.x, Spawner.transform.position.y, Spawner.transform.position.z), transform.rotation);
        spawnRate = 2;
    }
}
