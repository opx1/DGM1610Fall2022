using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableSpawnManager : MonoBehaviour
{
    public GameObject[] collectPrefabs;
    private float spawnRangex = 20f;
    private float spawnRangez = 20f;
    private float startDelay = 2f;
    private float spawnInterval = 1.5f;

    private void Start()
    {
        InvokeRepeating("SpawnRandomCollect", startDelay, spawnInterval);
    }

    void SpawnRandomCollect()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangex, spawnRangex), 3, spawnRangez);
        int ufoIndex = Random.Range(0, collectPrefabs.Length);
        Instantiate(collectPrefabs[ufoIndex], spawnPos, collectPrefabs[ufoIndex].transform.rotation);
    }
}
