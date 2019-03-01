using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour {

    public GameObject pipePrefab;
    public float spawnXPosition = 12.0F;
    public float spawnYPosition;
    public float spawnTriggerLocation = 6.0F;

    Transform lastSpawnedPipe;

	void Update () {
        if (lastSpawnedPipe == null)
        {
            spawnYPosition = Random.Range(-1.5F, 1.5F);
            lastSpawnedPipe = Instantiate(pipePrefab, new Vector3(spawnXPosition, spawnYPosition, 0), Quaternion.identity).transform;
        }
        else
        {
            if (lastSpawnedPipe.position.x < spawnTriggerLocation)
            {
                spawnYPosition = Random.Range(-1.5F, 1.5F);
                lastSpawnedPipe = Instantiate(pipePrefab, new Vector3(spawnXPosition, spawnYPosition, 0), Quaternion.identity).transform;
            }
        }
	}
}
