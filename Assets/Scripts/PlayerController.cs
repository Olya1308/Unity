using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10; // ��������

    public CharacterController characterController; //�� ���� ������ ������

    private Vector3 move; //��� ������

    public float gravity = -10; //���� ���������

    public float JumpHeight = 5; //���� (��� ������) ������� 

    private Vector3 velocity; //������ + �������� ������� ������

    public bool isGrounded; //�� �� ���� �� �?

    public Transform CheckGround; //��������� ���� ������

    public LayerMask groundLayer; //�� ����� ���� �� �������� �����

    public float rotationSpeed = 4.0f; // Speed of player rotation around the y-axis
    public float minXAngle = -90.0f; // Minimum allowed x-axis rotation
    public float maxXAngle = 90.0f; // Maximum allowed x-axis rotation

    private float _rotationX = 0.0f;


    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal"); // ��� ���� ������
        float z = Input.GetAxis("Vertical"); // ������ �����

        transform.Rotate(Vector3.up, x * rotationSpeed * Time.deltaTime);
        _rotationX = Mathf.Clamp(x, minXAngle, maxXAngle); 

        transform.localEulerAngles = new Vector3(_rotationX, transform.localEulerAngles.y, 0.0f);

        move = transform.right * x + transform.forward * z; //������ ����
       
        characterController.Move(move * speed * Time.deltaTime);// �����o��� ����

        isGrounded = Physics.CheckSphere(CheckGround.position, 0.1F, groundLayer);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -1f; // ��� ����� ����
        }

        if(isGrounded) // ���� �� �� ���� ...
        {            
            if (Input.GetButtonDown("Jump")) //�� ��������� �� �������� (Space)
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
        velocity.y = JumpHeight; // �������� ���� �� � ��������� == ��� �������
    }
}
