using System.Collections;
using System.Collections.Generic;
//using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;


//public Text ScoreText();

public class Player : MonoBehaviour
{
    public float moveSpeed = 550f;
    float movement = 0f;
    public static int Score = 0;
   // double timeLeft = 5f;


    void Start()
    {
        SetScoreText ();

    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log("recieve input");

        movement = Input.GetAxisRaw("Horizontal");

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            //Vector3 touchPosition = transform.RotateAround(Vector3.zero, Vector3.up, movement * Time.fixedDeltaTime * -moveSpeed); ;
            //touchPosition.y = 0f;
            // movement = transform.RotateAround(Vector3.zero, Vector3.up, movement * Time.fixedDeltaTime * -moveSpeed);
            //touchPosition = movement;
            //transform.position = touchPosition;
        }

       

        if (Score >= 10)
        {
            //FindObjectOfType<GameManager>().Awake();
            FindObjectOfType<PauseMenu>().YouWon();

        }
        Debug.Log("YOU WON UPDATE");


    }


    private void FixedUpdate()
    {
        Debug.Log("move object player");

        transform.RotateAround(Vector3.zero, Vector3.up, movement * Time.fixedDeltaTime * -moveSpeed);
    }


    void OnTriggerEnter (Collider collider)
    {
        if (collider.gameObject.CompareTag ("Enemy"))
        {
            // collider.gameObject.SetActive(false);
            //Enemy.speed = Enemy.speed += 100;
            Score++;
           
           // SetScoreText();
        }
      
    }

    void SetScoreText ()
    {
        //SetScoreText.text = "Score: " + Score.ToString ();
    }
}
