using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
  public GameObject topDownCamera;
  private GameObject playerCamera;

  private float lastMouseClickTime = -99;
  private float doubleClickTime = 0.5f;

  void Start()
  {
    playerCamera = Camera.main.gameObject;
  }

  void Update()
  {
    if (Input.GetMouseButtonDown(1))
    {
      if (Time.time - lastMouseClickTime < doubleClickTime)
      {
        if (topDownCamera.activeSelf)
        {
          topDownCamera.SetActive(false);
          playerCamera.SetActive(true);
          Cursor.lockState = CursorLockMode.Locked;
        }
        else
        {
          topDownCamera.SetActive(true);
          playerCamera.SetActive(false);
          Cursor.lockState = CursorLockMode.None;
        }
      }

      lastMouseClickTime = Time.time;
    }
  }
}
