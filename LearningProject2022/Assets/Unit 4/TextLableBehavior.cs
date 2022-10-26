using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TextLableBehavior : MonoBehaviour
{
  public Text label;
  public FloatData dataObj;
  public IntData damgObj;

  private void Start()
  {
    label = GetComponent<Text>();
    UpdateLabel();
  }


  public void UpdateLabel()
  {
    label.text = dataObj.value.ToString(CultureInfo.InvariantCulture);
    label.text = damgObj.value.ToString(CultureInfo.InvariantCulture);
  }
}
