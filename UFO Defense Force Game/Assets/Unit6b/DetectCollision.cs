using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public ScoreManager scoreManager;

    public int scoreToGive;

    public bool destroyed;
    
    public GameObject uFO;
    public GameObject explosion;
    public Transform uFOPosition;

    private void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        destroyed = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        uFOPosition = uFO.transform;
        scoreManager.IncreaseScore(scoreToGive);
        Destroy(gameObject);
        Destroy(other.gameObject);
        destroyed = true;
        if (destroyed == true)
        {
            Instantiate(explosion, uFOPosition.transform.position, uFOPosition.transform.rotation);
            Debug.Log("pew");
        }
    }
}
