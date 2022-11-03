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
  

  private void Update()
  {
      if (Input.GetKeyDown(KeyCode.S))
      {
          Vector3 spawnPos = new Vector3(Random.Range(-spawnRangex, spawnRangex), 0, spawnRangez);
          int ufoIndex = Random.Range(0, ufoPrefabs.Length);
          Instantiate(ufoPrefabs[ufoIndex], spawnPos, ufoPrefabs[ufoIndex].transform.rotation);
      }
  }
}
