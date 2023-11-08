using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerActivate : MonoBehaviour
{
  public GameObject activatable;

  private void OnTriggerEnter(Collider other)
  {
    if (other.tag == "MainCamera")
    {
      activatable.SetActive(true);
    }
    
  }
}
