using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu]
public class IntData : ScriptableObject
{
   public int value;

   public void UpdateValue(int number)
   {
      value += number;
   }

   public void ReplaceValue(int number)
   {
      value = number;
   }

   public void SetValue(IntData obj)
   {
      value = obj.value;
   }

   public void CompareValue(IntData obj)
   {
      if (value >= obj.value)
      {
         
      }
      else
      {
         value = obj.value;
      }
   }
}
