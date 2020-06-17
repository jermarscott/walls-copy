using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Goal : MonoBehaviour
{


    public static int badScore = 0;

    public Text badScoreText;

   // public int whiteNoHappened;
   // bool alreadyBadDone = false;


    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Enemy"))
        {
            // collider.gameObject.SetActive(false);
            badScore++;
            // SetScoreText();
        }
    }
    // void OnCollisionEnter(Collision col2)
    // {
    //
    //     Debug.Log("Destroyd");
    //
    //     if (col2.collider.tag == ("BadPoint"))
    //     {
    //
    //           badScore++;
    //
    //
    //
    //
    //
    //         if (!alreadyBadDone)
    //         {
    //             alreadyBadDone = true;
    //
    //             badScore++;
    //         }
    //
    //     }
    //
    // }
}