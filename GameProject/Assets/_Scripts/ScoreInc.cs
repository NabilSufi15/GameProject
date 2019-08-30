using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreInc : MonoBehaviour
{
    public AudioSource GemSound;

    void OnTriggerEnter(Collider other)
    {
        // if player collides, increase score by 100 and destroy object
        CurrentScore.GameScore += 100;
        GemSound.Play();
        Destroy(gameObject);
    }
}

