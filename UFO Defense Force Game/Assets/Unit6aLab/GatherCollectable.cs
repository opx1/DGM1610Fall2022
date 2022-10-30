using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class GatherCollectable : MonoBehaviour
{
    public BoolData collectObj;
    public void Updatebool()
    {
        collectObj.collectable = true;
        Debug.Log("Collected");
    }
    
}
