using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MatchBehavior : MonoBehaviour
{
   public ID idObj;
   public UnityEvent matchEvent, noMatchEvent;

   private void OnTriggerEnter(Collider other)
   {
      var tempObj = other.GetComponent<IdContainerBehavior>();
      if (tempObj == null)
         return;
      
      var idOther = tempObj.idObj;
      if (idOther == idObj)
      {
         matchEvent.Invoke();
      }
      else
      {
         noMatchEvent.Invoke();
      }
   }
}
