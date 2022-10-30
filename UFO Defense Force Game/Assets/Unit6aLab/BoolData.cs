using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class BoolData : ScriptableObject
{
    public bool collectable;

        public void Collected()
        {
            collectable = true;
        }
    
}
