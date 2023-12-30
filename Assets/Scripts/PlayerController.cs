using System.Collections;
using System.Collections.Generic;
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


    // Start is called before the first frame update
    void Start() 
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal"); // ��� ���� ������
        float z = Input.GetAxis("Vertical"); // ������ �����

        move = transform.right * x + transform.forward * z; //������ ����

        characterController.Move(move * speed * Time.deltaTime);// �����o��� ����

        isGrounded = Physics.CheckSphere(CheckGround.position, 0.1F, groundLayer);

        Debug.Log(velocity.y);

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
