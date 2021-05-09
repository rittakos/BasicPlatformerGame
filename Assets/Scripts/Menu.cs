using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void restart()
    {
        SceneManager.LoadScene("SampleScene");
    }


    public void exitGame()
    {
        Application.Quit();
    }
}
