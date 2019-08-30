using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public bool NotPaused;
    public GameObject Player;
    public GameObject pauseMenu;

    // Update is called once per frame
    void Update()
    {
        //If Tab is pressed down
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            // if it's not paused, play game as normal
            if (NotPaused)
            {
                ResumeGame();
                Time.timeScale = 1f;
            }
            else
            {
                //Freezes game screen and time. Pause menu becomes visible
                Time.timeScale = 0f;
                Player.GetComponent<FirstPersonController>().enabled = false;
                NotPaused = true;
                pauseMenu.SetActive(true);
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }

        }
    }
    
    public void ResumeGame()
    {
        //resumes game. hides cursor, allow player to move
        NotPaused = false;
        pauseMenu.SetActive(false);
        Player.GetComponent<FirstPersonController>().enabled = true;
        Cursor.visible = false;
    }

    public void MainMenu()
    {
        //unfreeze game time and loads the main menu scene
        Time.timeScale = 1f; 
        SceneManager.LoadScene(0);
    }
}

    
