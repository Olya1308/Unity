using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Collect : MonoBehaviour
{
    public static int AmountRes_Food = 0;

    public TextMeshPro GoldTextRes;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 30 * Time.deltaTime, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            AmountRes_Food++;
            //SetActive(false);
            Destroy(gameObject);
        }
    }
}
