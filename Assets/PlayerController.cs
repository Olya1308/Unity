using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10; // швидк≥сть
    public CharacterController characterController; //€к саме рухаЇмо гравц€

    private Vector3 move; //рух гравц€


    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(speed);
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal"); // рух вл≥во вправо
        float z = Input.GetAxis("Vertical"); // вперед назад

        move = transform.right * x + transform.forward * z; //напр€м руху

        characterController.Move(move * speed * Time.deltaTime);// контрелер руху

        Debug.Log(x + " " + z);

    }
}
