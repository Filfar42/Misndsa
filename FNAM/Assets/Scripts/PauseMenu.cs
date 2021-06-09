using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public static bool GameIsPaused = false;
    [SerializeField] GameObject pauseMenu;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!GameIsPaused)
            {
                PauseGame();
            }
            else
            {
                ResumeGame();
            }
        }
        
    }
    void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;

    }

    public void MainMenuScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);
        ResumeGame();
    }

    public void QuitScene()
    {
        Application.Quit();
        Debug.Log("Quit!");
    }
}
