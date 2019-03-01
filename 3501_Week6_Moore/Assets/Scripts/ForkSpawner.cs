using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForkSpawner : MonoBehaviour
{
    public General general;

    public GameObject forkPrefab;
    public float spawnXPosition = -1.5F;
    public float spawnYPosition;
    public float spawnTriggerLocation = -12.0F;

    Transform lastSpawnedFork;

    void Update()
    {
        if (general.gameOn)
        {
            if (lastSpawnedFork == null)
            {
                spawnYPosition = Random.Range(-1.5F, 1.5F);
                lastSpawnedFork = Instantiate(forkPrefab, new Vector3(spawnXPosition, spawnYPosition, 0), Quaternion.identity).transform;
            }
            else
            {
                if (lastSpawnedFork.position.x < spawnTriggerLocation)
                {
                    spawnYPosition = Random.Range(-1.5F, 1.5F);
                    lastSpawnedFork = Instantiate(forkPrefab, new Vector3(spawnXPosition, spawnYPosition, 0), Quaternion.identity).transform;
                }
            }
        }
    }
}
