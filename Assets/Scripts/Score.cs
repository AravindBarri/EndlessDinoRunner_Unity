using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    int score = 0;
    //oncollisionenter is used to detect collisons
    private void OnCollisionEnter(Collision collision)
    {
        scorecalculator();
        print(collision.gameObject.tag);
        //compare tag is used to compare 
        if (collision.gameObject.CompareTag("enemy"))
        {
            // destroy removes gameobject ,component  
            Destroy(collision.gameObject, 2.0f);
        }
        //else if(collision.gameObject.CompareTag("Asteroid"))
        //{
        // print("Game over");
        // print("score is" + transform.position.x);
        // Destroy(collision.gameObject, 0);

        // }


    }
    void scorecalculator()
    {
        score++;
        print("score is:" + score);
    }

}