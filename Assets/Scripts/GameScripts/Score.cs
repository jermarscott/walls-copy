using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    public  int score = 0;
 

    public Text scoreText;
    public static int POINT;
   

    // Update is called once per frame
    void Update()
    {
       
        score = Enemy.POINT;
        scoreText.text = score.ToString("0");
        Debug.Log("SCORE UPDATE");
    }

}
