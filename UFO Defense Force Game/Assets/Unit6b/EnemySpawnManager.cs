using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemySpawnManager : MonoBehaviour
{
  public GameObject[] ufoPrefabs;
  private float spawnRangex = 20f;
  private float spawnRangez = 20f;
  private float startDelay = 2f;
  private float spawnInterval = 1.5f;

  private void Start()
  {
      InvokeRepeating("SpawnRandomUFO", startDelay, spawnInterval);
  }

  void SpawnRandomUFO()
  {
    Vector3 spawnPos = new Vector3(Random.Range(-spawnRangex, spawnRangex), 3, spawnRangez);
    int ufoIndex = Random.Range(0, ufoPrefabs.Length);
    Instantiate(ufoPrefabs[ufoIndex], spawnPos, ufoPrefabs[ufoIndex].transform.rotation);
  }
 
}
