using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicController : MonoBehaviour
{
    public float speed_forward = 10.0f; // швидкість вперед
    public float speed_steer = 4.0f; //швидкість повороту
    public CharacterController characterController; 
    private Vector3 move; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal"); // рух вліво вправо

        move = transform.right * x; //напрям руху вліво-вправо

        characterController.Move(move * speed_steer * Time.deltaTime); //сам перехід вліво вправо

        transform.Translate(Vector3.forward * speed_forward * Time.deltaTime); //сам рух вперед автоматично
    }
}
