using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicController : MonoBehaviour
{
    public float speed_forward = 10.0f; // швидк≥сть вперед
    public float speed_steer = 4.0f; //швидк≥сть повороту
    public CharacterController characterController; 
    private Vector3 move;

    //->
    public bool isGrounded; //ми на земл≥ чи н≥?
    public Transform CheckGround; //положенн€ н≥жок гравц€
    public LayerMask groundLayer; //на основ≥ слою ми створили зм≥нну

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal"); // рух вл≥во вправо

        move = transform.right * x; //напр€м руху вл≥во-вправо

        characterController.Move(move * speed_steer * Time.deltaTime); //сам перех≥д вл≥во вправо

        transform.Translate(Vector3.forward * speed_forward * Time.deltaTime); //сам рух вперед автоматично

        //->
        isGrounded = Physics.CheckSphere(CheckGround.position, 0.1F, groundLayer);
    }
}
