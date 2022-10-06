using UnityEngine;
using System.Collections;

public class ActiveObjects : MonoBehaviour
{
    void Start ()
    {
        gameObject.SetActive(false);
    }
}


using UnityEngine;
using System.Collections;

public class CheckState : MonoBehaviour
{
    public GameObject myObject;
    
    
    void Start ()
    {
        Debug.Log("Active Self: " + myObject.activeSelf);
        Debug.Log("Active in Hierarchy" + myObject.activeInHierarchy);
    }
}
