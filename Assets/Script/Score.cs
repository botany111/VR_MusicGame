using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text ScoreText;

    public static int score;


    // Update is called once per frame
    void Update()
    {
        ScoreText.text = score.ToString();

        
    }


}
