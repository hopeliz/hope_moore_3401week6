using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleSpawner : MonoBehaviour
{
    public General general;

    public GameObject bubblesPrefab;
    public float spawnXPosition = -1.5F;
    public float spawnYPosition;
    public float spawnTriggerLocation = -50;

    Transform lastSpawnedFork;

    void Update()
    {

        if (general.gameOn)
        {
            if (lastSpawnedFork == null)
            {
                lastSpawnedFork = Instantiate(bubblesPrefab, new Vector3(spawnXPosition, spawnYPosition, 0), Quaternion.identity).transform;
            }
            else
            {
                if (lastSpawnedFork.position.x < spawnTriggerLocation)
                {
                    lastSpawnedFork = Instantiate(bubblesPrefab, new Vector3(spawnXPosition, spawnYPosition, 0), Quaternion.identity).transform;
                }
            }
        }
    }
}
