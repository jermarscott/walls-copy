
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BadScore : MonoBehaviour
{
   public static int badScorePoint = 0;

    public static int badScore = 0;
    public static int POINT;
    public static int Score;
    //bool alreadyBadDone = false;
    public Text badScoreText;

    // public int whiteNoHappened;
 



    // Update is called once per frame
    void Awake()
    {
        
    }
    void Update()
    {
        badScorePoint = Enemy.badScore;
        badScoreText.text = badScorePoint.ToString("0");

        if (badScorePoint >= 10)
        {
            //FindObjectOfType<GameManager>().Awake();
            FindObjectOfType<PauseMenu>().GameOver();
           
        }  
        Debug.Log("BADSCORE UPDATE");


        if (Score >= 10)
        {
            //FindObjectOfType<GameManager>().Awake();
           // FindObjectOfType<GameManager>().YouHaveWon();

        }
        Debug.Log("Score UPDATE");

    }




}
