using UnityEngine;
using System.Collections;

public class EnableComponents : MonoBehaviour
{
    private Light lampLight;
    
    
    void Start ()
    {
        lampLight = GetComponent<Light>();
    }
    
    
    void Update ()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            lampLight.enabled = !lampLight.enabled;
        }
    }
}