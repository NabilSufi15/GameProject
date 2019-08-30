using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2 : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        //load GameCompleted Scenes
        SceneManager.LoadScene(3);
    }
}
