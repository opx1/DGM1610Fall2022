using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionTrigger : MonoBehaviour
{
    public GameObject uFO;
    public GameObject explosion;
    public Transform uFOPosition;

    public DetectCollision detectCollision;
    
    void Update()
    {
        uFOPosition = uFO.transform;
        
        if (detectCollision.destroyed == true)
        {
            Instantiate(explosion, uFOPosition.transform.position, uFOPosition.transform.rotation);
            Debug.Log("pew");
        }
    }

}
