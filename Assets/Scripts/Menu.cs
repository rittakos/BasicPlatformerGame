using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public string nextScene;
    public string currentScene;

    public void restart()
    {
        SceneManager.LoadScene(currentScene);
    }

    public void nextLevel()
    {
        SceneManager.LoadScene(nextScene);
    }


    public void exitGame()
    {
        Application.Quit();
    }
}
