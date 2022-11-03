using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
  public GameObject[] ufoPrefabs;

  public int ufoIndex;

  private void Update()
  {
      if (Input.GetKeyDown(KeyCode.S))
      {
          Instantiate(ufoPrefabs[ufoIndex], new Vector3(0, 0, 20), ufoPrefabs[ufoIndex].transform.rotation);
      }
  }
}
