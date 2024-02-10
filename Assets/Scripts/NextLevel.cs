using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    
    void Update()
    {
        transform.Rotate(0, -20 * Time.deltaTime, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Level 1 Done");
            SceneManager.LoadScene("Scenes/Done_level_1");
        }
    }
}
