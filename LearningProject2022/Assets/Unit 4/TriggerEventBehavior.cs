using System;
using UnityEngine.Events;
using UnityEngine;

public class TriggerEventBehavior : MonoBehaviour
{
   public UnityEvent triggerEnterEvent;

   private void OnTriggerEnter(Collider other)
   {
      triggerEnterEvent.Invoke();
   }
}
