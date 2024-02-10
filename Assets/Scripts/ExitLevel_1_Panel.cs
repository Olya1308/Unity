using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitLevel_1_Panel : MonoBehaviour
{
    public GameObject Panel;

    public void ShowPanel()
    {
        Panel.SetActive(true);
    }

    public void GoToMain()
    {
        Panel.SetActive(false);
        SceneManager.LoadScene("Scenes/Menu");
    }

    public void NoExitBtn()
    {
        Panel.SetActive(false);
    }

    void Start()
    {
        Panel.SetActive(false);
    }

}
