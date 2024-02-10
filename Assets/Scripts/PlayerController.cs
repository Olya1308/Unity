using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10; // швидк≥сть

    public CharacterController characterController; //€к саме рухаЇмо гравц€

    private Vector3 move; //рух гравц€

    public float gravity = -10; //сила прит€ж≥нн€

    public float JumpHeight = 5; //сила (або висота) стрибка 

    private Vector3 velocity; //напр€м + швидк≥сть земного т€ж≥нн€

    public bool isGrounded; //ми на земл≥ чи н≥?

    public Transform CheckGround; //положенн€ н≥жок гравц€

    public LayerMask groundLayer; //на основ≥ слою ми створили зм≥нну

    public float rotationSpeed = 4.0f; // Speed of player rotation around the y-axis
    public float minXAngle = -90.0f; // Minimum allowed x-axis rotation
    public float maxXAngle = 90.0f; // Maximum allowed x-axis rotation

    private float _rotationX = 0.0f;


    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal"); // рух вл≥во вправо
        float z = Input.GetAxis("Vertical"); // вперед назад

        transform.Rotate(Vector3.up, x * rotationSpeed * Time.deltaTime);
        _rotationX = Mathf.Clamp(x, minXAngle, maxXAngle); 

        transform.localEulerAngles = new Vector3(_rotationX, transform.localEulerAngles.y, 0.0f);

        move = transform.right * x + transform.forward * z; //напр€м руху
       
        characterController.Move(move * speed * Time.deltaTime);// контрoлер руху

        isGrounded = Physics.CheckSphere(CheckGround.position, 0.1F, groundLayer);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -1f; // нас т€гне вниз
        }

        if(isGrounded) // €кщо ми на земл≥ ...
        {            
            if (Input.GetButtonDown("Jump")) //та нитискаЇмо на стрибати (Space)
            {
                Jump();
            }
        }
        else
        {
            velocity.y += gravity * Time.deltaTime;
        }

        characterController.Move(velocity * Time.deltaTime);
    }

    private void Jump()
    {
        velocity.y = JumpHeight; // швидк≥сть руху по ” координат≥ == сил≥ стрибка
    }
}
