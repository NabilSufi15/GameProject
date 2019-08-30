using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    void Start()
    {
        //CurrentScore.GameScore = 0;
        StartCoroutine(End());
    }

    void Update()
    {
        //makes curso visible and unlocks cursor state
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    IEnumerator End()
    {
        // waits 5 seconds before loading next scene
        yield return new WaitForSeconds(5f);
        Time.timeScale = 1f;
        SceneManager.LoadSceneAsync(0);
    }
}
