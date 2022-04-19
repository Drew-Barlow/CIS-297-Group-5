using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    bool paused = false;
    public void PausedGame()
    {
        if (Input.GetKeyDown("escape"))
        {
            if (paused == true){
                Time.timeScale = 1.0f;
                Cursor.visible = false;
                Screen.lockCursor = true;
                paused = false;
            }
            else
            {
                Time.timeScale = 0.0f;
                Cursor.visible = true;
                Screen.lockCursor = false;
                paused = true;
            }
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
