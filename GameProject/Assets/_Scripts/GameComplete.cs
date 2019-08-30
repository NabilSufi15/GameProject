using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameComplete : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        
        //Load game complete scene
        SceneManager.LoadScene(4);
    }
}
