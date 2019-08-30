using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public static int MaxHealth = 100;
    public static int Health;
    public GameObject HealthBar;

    // Update is called once per frame
    void Update()
    {
        //constantly updates the players health
        Health = MaxHealth;
        //updates the health bar text in game UI
        HealthBar.GetComponent<Text>().text = "HEALTH: " + Health;
        if(Health == 0)
        {
            //Changes the scene to game over once health reaches 0
            Time.timeScale = 1f;
            SceneManager.LoadScene(1);
        }
    }

    
    
}

