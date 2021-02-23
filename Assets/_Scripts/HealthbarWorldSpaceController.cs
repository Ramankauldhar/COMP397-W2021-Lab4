using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthbarWorldSpaceController : MonoBehaviour
{

  public Transform playerCamera;

  void start()
  {
    playerCamera = GameObject.Find("PlayerCamera").transform;
  }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.LookAt(transform.position + playerCamera.forward);
    }
}
