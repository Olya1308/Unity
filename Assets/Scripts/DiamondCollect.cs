using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DiamondCollect : MonoBehaviour
{
    public static int AmountRes_Diamond = 0;

    public TextMeshProUGUI DiamondTextRes;
    public GameObject Teleport_1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            AmountRes_Diamond++;
            
            Destroy(gameObject);

            DiamondTextRes.text = AmountRes_Diamond.ToString();

            if(AmountRes_Diamond == 3)
            {
                Teleport_1.SetActive(true);
            }
        }
    }
}
