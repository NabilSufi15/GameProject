using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    public GameObject Name;
    public string Username;

    public void Start()
    {
        //resets game values back to its default values
        CurrentScore.GameScore = 0;
        PlayerHealth.MaxHealth = 100;
        Ammo.LoadedAmmo = 0;
        Ammo.CurrentAmmo = 0;
        //PlayerPrefs.DeleteAll();
    }

    public void Update()
    {
        //Get's username of current player
        Username = Name.GetComponent<InputField>().text;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void MainMenu()
    {
        //Load main menu scene
        SceneManager.LoadSceneAsync(0);
    } 

    public void NewGame()
    {
        //Stores username and loads the level1 game scene
        PlayerPrefs.SetString("username", Username);
        SceneManager.LoadSceneAsync(2);
        
    }

    public void QuitGame()
    {
        //quits application
        Debug.Log("Quit");
        Application.Quit();
    }
}
