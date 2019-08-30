using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeaderBoard : MonoBehaviour
{

    public Text name1;
    public Text score1; 
    // Start is called before the first frame update
    void Start()
    {
        //If current score is higher than the high score, replaces score and name
        if(PlayerPrefs.GetInt("score") > PlayerPrefs.GetInt("score1"))
        {
            PlayerPrefs.SetInt("score1", PlayerPrefs.GetInt("score"));

            PlayerPrefs.SetString("name1", PlayerPrefs.GetString("username"));
           
        }  

        name1.text = PlayerPrefs.GetString("name1");
        score1.text = PlayerPrefs.GetInt("score1").ToString();

    }
   



}
