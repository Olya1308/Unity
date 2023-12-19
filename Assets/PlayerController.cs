using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10; // ��������
    public CharacterController characterController; //�� ���� ������ ������

    private Vector3 move; //��� ������


    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(speed);
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal"); // ��� ���� ������
        float z = Input.GetAxis("Vertical"); // ������ �����

        move = transform.right * x + transform.forward * z; //������ ����

        characterController.Move(move * speed * Time.deltaTime);// ��������� ����

        Debug.Log(x + " " + z);

    }
}
