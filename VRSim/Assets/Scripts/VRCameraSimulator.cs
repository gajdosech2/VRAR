using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRCameraSimulator : MonoBehaviour
{
  public float rotSpeed = 400.0f;
  public float movementSpeed = 5.0f;
  private GameObject playerCamera;

  private void Start()
  {
    Cursor.lockState = CursorLockMode.Locked;
    transform.eulerAngles = Vector3.zero;
    Camera.main.transform.eulerAngles = Vector3.zero;
    playerCamera = Camera.main.gameObject;
  }

  void Update()
  {
    if (playerCamera.activeSelf == false)
    {
      return;
    }

    transform.Rotate(0, Input.GetAxis("Mouse X") * Time.deltaTime * rotSpeed, 0);
    //transform.Rotate(Input.GetAxis("Mouse Y") * Time.deltaTime * -rotSpeed, 0, 0);

    if (Input.GetKey(KeyCode.W))
    {
      transform.position += transform.forward * movementSpeed * Time.deltaTime;

      //float angle = transform.rotation.eulerAngles.y;
      //transform.position += new Vector3
      //    (Mathf.Sin(Mathf.Deg2Rad * angle),
      //    0,
      //    Mathf.Cos(Mathf.Deg2Rad * angle)) *
      //    Time.deltaTime * movementSpeed;
    }

    if (Input.GetKey(KeyCode.S))
    {
      transform.position -= transform.forward * movementSpeed * Time.deltaTime;
    }
  }
}
