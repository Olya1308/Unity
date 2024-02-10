using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Collect : MonoBehaviour
{
    public static int AmountRes_Gold = 0;

    public TextMeshProUGUI GoldTextRes;


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            AmountRes_Gold++;

            Destroy(gameObject);

            GoldTextRes.text = AmountRes_Gold.ToString();
        }
    }
}
