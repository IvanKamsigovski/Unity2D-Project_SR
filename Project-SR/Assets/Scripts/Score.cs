using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class Score : MonoBehaviour
{
    public static int scoreValue;
    public TMP_Text scoreText;
    
    void Update()
    {
        scoreText.text = scoreValue.ToString();
    }
}
