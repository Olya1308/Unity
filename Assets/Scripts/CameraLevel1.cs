using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLevel1 : MonoBehaviour
{
    public float mouseSensitivity = 2.0f;
    public float movementSpeed = 5.0f;

    void Start()
    {

    }


    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        transform.Rotate(Vector3.up * mouseX);
        Camera.main.transform.Rotate(Vector3.left * mouseY);
    }
    
}
