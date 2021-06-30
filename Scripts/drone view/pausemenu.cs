using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pausemenu : MonoBehaviour
{
    public static bool isPaused = false;
    public GameObject PausemenuUI;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("Quitting game !!!");
            Application.Quit();
        }
    }

    void Pause()
    {
        PausemenuUI.SetActive(true);
        Time.timeScale = 0.5f;
        isPaused = true;
    }

    void Resume()
    {
        PausemenuUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void MainMenu()
    {
        Debug.Log("Loading Menu !!!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);                       
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game !!!");
        Application.Quit();
    }
}
