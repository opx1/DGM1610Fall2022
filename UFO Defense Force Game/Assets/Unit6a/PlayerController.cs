using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed;
    public float xRange = 20;
    
    public Transform blaster;
    public GameObject lazerBolt;

    public AudioClip blastSound;
    public AudioClip endSound;
    private AudioSource blasterAudio;

    public GameManager gameManager;

    private void Start()
    {
        blasterAudio = GetComponent<AudioSource>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }


    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        
        transform.Translate(Vector3.right * (horizontalInput * speed * Time.deltaTime));

        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.Space) && gameManager.isGameOver == false)
        {
            Instantiate(lazerBolt, blaster.transform.position, lazerBolt.transform.rotation);
            blasterAudio.PlayOneShot(blastSound);
        }

        if (gameManager.isGameOver==true)
        {
            blasterAudio.PlayOneShot(endSound);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
