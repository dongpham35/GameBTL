using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void MoveMenuGame()
    {
        Time.timeScale = 1.0f;
        ItemCollection.score = 0;
        SceneManager.LoadScene(0);
    }

    public void PlayAgain()
    {
        ItemCollection.score = 0;
        SceneManager.LoadScene(3);
    }

    public void ExitApplication()
    {
        Application.Quit();
    }

    public void Resume()
    {
        Time.timeScale = 1.0f;
    }
}