using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CurrentScore : MonoBehaviour
{
    public static int GameScore;
    public int InternalScore;
    public GameObject ScoreView;

    // Update is called once per frame
    public void Update()
    {
        //Updates current score of player
        InternalScore = GameScore;
        ScoreView.GetComponent<Text>().text = "" + InternalScore;
        PlayerPrefs.SetInt("score", GameScore);

    }
}
