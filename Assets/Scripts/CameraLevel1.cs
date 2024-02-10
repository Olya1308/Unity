using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLevel1 : MonoBehaviour
{
    public float rotationSpeed = 4.0f; // Speed of camera rotation
    public float minYAngle = -90.0f; // Minimum allowed y-axis rotation
    public float maxYAngle = 90.0f; // Maximum allowed y-axis rotation
    public float minXAngle = -90.0f; // Minimum allowed x-axis rotation
    public float maxXAngle = 90.0f; // Maximum allowed x-axis rotation

    private float _rotationX = 0.0f;
    private float _rotationY = 0.0f;
    private Transform target;

    public GameObject Teleport_1;

    void Start()
    {
        Teleport_1.SetActive(false);
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        _rotationX += mouseX * rotationSpeed;
        _rotationY -= mouseY * rotationSpeed;

        _rotationY = Mathf.Clamp(_rotationY, minYAngle, maxYAngle); 
        _rotationX = Mathf.Clamp(_rotationX, minXAngle, maxXAngle); 

        transform.localRotation = Quaternion.Euler(_rotationY, _rotationX, 0.0f);
        //target.localRotation = Quaternion.Euler(0.0f, _rotationX, 0.0f);
    }


    
    
}
