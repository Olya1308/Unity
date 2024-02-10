using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Scenes/Level_1");
    }

    public void Quit()
    {
        //UnityEditor.EditorApplication.isPlaying = false; // для Unity
       Application.Quit(); // для додатку при зборці !
    }

    public void AboutGame()
    {
        SceneManager.LoadScene("Scenes/AboutMenu");
    }

    public void SettingsGame() 
    {
        SceneManager.LoadScene("Scenes/SettingsMenu");
    }

    public void LevelsOfGame()
    {
        SceneManager.LoadScene("Scenes/LevelsMenu");
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("Scenes/Menu");
    }

    public void FirstLevelStart()
    {
        SceneManager.LoadScene("Scenes/Level_1");
    }

    public void SecondLevelStart()
    {
        SceneManager.LoadScene("Scenes/Level_2");
    }
   
}
