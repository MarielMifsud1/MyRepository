using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class score_1 : MonoBehaviour {
    public int addition;
    public static int playerScores;
    public int maxScore;
    public Text myscore;
    public static int score;
  
    
    

	// Use this for initialization
	void Start () {
        score = 0;
	}
	
	// Update is called once per frame
	void Update () {
        myscore.text = "Player 1: " + score;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (highscore.hscore == 1)
        {
            score = score + addition;
            playerScores = playerScores + addition;
            print(score);
            highscore.player1Score += 1;

            if (highscore.hscore == 1 && score == 5)
            {
                score = 0;
                highscore.hscore += 1;
                SceneManager.LoadScene("Level2");
            }
        }
        else if (highscore.hscore == 2)
        {
            
            score += 2;
            highscore.player1Score = highscore.player1Score + 2;

            if (highscore.hscore == 2 && score == 10)
            {
                SceneManager.LoadScene("Level3");
                score = 0;
                highscore.hscore += 1;
            }
        }

        else if (highscore.hscore == 3 ) 
        {

           
            score += 3;
            highscore.player1Score = highscore.player1Score + 3;

            if (highscore.hscore == 3 && score == 18)
            {
                if (highscore.hscore == 3 &&  score == 18)
                {
                    SceneManager.LoadScene("highscore");
                    score = 0;
                    highscore.hscore += 1;
                }
            }


        }





        ball.gameStarted = false;
            
       
    }


    

    }
