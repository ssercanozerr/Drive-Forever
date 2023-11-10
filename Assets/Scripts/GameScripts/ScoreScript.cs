using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text scoreTxt;
    public static int score;
    void Start()
    {
        score = 0;
    }

    void Update()
    {
        scoreTxt.text = score.ToString();        
    }
}
