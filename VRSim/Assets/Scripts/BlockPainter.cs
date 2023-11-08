using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockPainter : MonoBehaviour
{
  GameObject playerCamera;
  List<Color> colors = new List<Color> { Color.red, Color.green, Color.blue };
  int click = 0;

  void Start()
  {
    playerCamera = Camera.main.gameObject;
  }

  void Update()
  {
    if (playerCamera.activeSelf == true)
    {
      return;
    }

    if (Input.GetMouseButtonDown(0))
    {
      RaycastHit hit;

      Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
      if (Physics.Raycast(ray.origin, ray.direction, out hit))
      {
        if (hit.transform.tag == "Interactable")
        {
          hit.transform.GetComponent<Renderer>().material.color = colors[click];
          click = (click + 1) % colors.Count;
        }
      }

    }
  }
}
