using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenuUI;
    [SerializeField] private bool isPauased;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPauased = !isPauased;
        }

        if (isPauased)
        {
            Paused();
        }

        else
        {
            Resume();
        }
    }

    void Paused()
    {
        Time.timeScale = 0;
        AudioListener.pause = true;
        pauseMenuUI.SetActive(true);
    }

    public void Resume()
    {
        Time.timeScale = 1;
        AudioListener.pause = false;
        pauseMenuUI.SetActive(false);
        isPauased = false;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
