using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Collect : MonoBehaviour
{
    public static int AmountRes_Gold = 0;

    public TextMeshProUGUI GoldTextRes;


    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            AmountRes_Gold++;
            //SetActive(false);
            Destroy(gameObject);

            GoldTextRes.text = AmountRes_Gold.ToString();
        }
    }
}
