using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LastScoreScript : MonoBehaviour
{
    public Text lastScoreTxt;
    void Update()
    {
        lastScoreTxt.text = ScoreScript.score.ToString();
    }
}
