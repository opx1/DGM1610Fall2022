using UnityEngine;
using System.Collections;

public class UpdateAndFixedUpdate : MonoBehaviour
{
    void FixedUpdate ()
    {
        Debug.Log("FixedUpdate time :" + Time.deltaTime);
        //called every physics step
        //FixedUPdate intervals are consistent
        //Used for regular updates such as:
        //adjusting physics (Rigidbody) objects
    }
    
    
    void Update ()
    {
        Debug.Log("Update time :" + Time.deltaTime);
        //called every frame
        //Used for regular updates such as:
        //moving non-physics objects
        //simple timers
        // reciving input
        //update interval times vary
    }
}
