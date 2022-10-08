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
    public GameObject mainObject;
    
    
    void Start ()
    {
        Debug.Log("Active Self: " + mainObject.activeSelf);
        Debug.Log("Active in Hierarchy" + mainObject.activeInHierarchy);
    }
}
