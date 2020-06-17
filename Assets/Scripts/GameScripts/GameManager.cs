
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int POINT;
    public static int Score;

    public static int badScorePoint;
    public static bool gameHasEnded = false;
    //public  static bool alreadyDone;
   // public  static bool alreadyBadDone;
    public float restartDelay= 3.5f;

    public Text ScoreText;
    public Text BadScoreText;

    public GameObject GAMEOVERUI;
    //public GameObject YouWon;



    public void Awake()
    {



    // badScorePoint = Enemy.badScore;
    // badScorePoint.ToString("0");
    // POINT = GetComponant<Score.Text>();

    // badScorePoint = Playerprefs.GetInt("POINT");
    }


//
//    public void EndGame()
//    {
//
//
//        if (gameHasEnded == false)
//        {
//
//           // gameHasEnded = true;
//            Debug.Log("GAME OVER");
//            GAMEOVERUI.SetActive(true);
//            // badScorePoint = 0;
//            Time.timeScale = 0f;
//
//            if (Input.anyKey)
//            {
//                GAMEOVERUI.SetActive(false);
//                Invoke("Restart", restartDelay);
//            }
//        }
//    }
//
//
//
   //public void YouHaveWon()
   //{
   //
   //
   //    if (POINT >=10 )
   //    {
   //
   //        // gameHasEnded = true;
   //        Debug.Log("You Won");
   //        YouWon.SetActive(true);
   //        // badScorePoint = 0;
   //        Time.timeScale = 0f;
   //
   //        if (Input.anyKey)
   //        {
   //            YouWon.SetActive(false);
   //            Invoke("Restart", restartDelay);
   //        }
   //    }
   //}

    void Restart()
    {
       SceneManager.LoadScene("Game");

    }


    void OnLevelWasLoaded(int level)
    {
        Enemy.POINT = 0;
        Enemy.badScore = 0;
       // Enemy.alreadyDone = false;
        //Enemy.alreadyBadDone = false;
    }
}
