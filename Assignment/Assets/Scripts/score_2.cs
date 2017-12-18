using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class score_2 : MonoBehaviour
{

    public Text myscore2;
    public int maxScore;
    public int addition;
    public static int playerScores;
    public static int score2 = 0;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {



        myscore2.text = "Player 2: " + score2;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {



        if (highscore.hscore == 1)
        {
            score2 = score2 + addition;
            playerScores = playerScores + addition;
            print(score2);
            highscore.player2Score += 1;

            if (highscore.hscore == 1 && score2 == 5)
            {
                score2 = 0;
                highscore.hscore += 1;
                SceneManager.LoadScene("Level2");
            }
        }
        else if (highscore.hscore == 2)
        {

            score2 += 2;
            highscore.player2Score = highscore.player2Score + 2;

            if (highscore.hscore == 2 && score2 == 10)
            {
                SceneManager.LoadScene("Level3");
                score2 = 0;
                highscore.hscore += 1;
            }
        }

        else if (highscore.hscore == 3)
        {


            score2 += 3;
            highscore.player2Score = highscore.player2Score + 3;

            if (highscore.hscore == 3 && score2 == 18)
            {
                if (highscore.hscore == 3 && score2 == 18)
                {
                    SceneManager.LoadScene("highscore");
                    score2 = 0;
                    highscore.hscore += 1;
                }
            }



            ball.gameStarted = false;
        }
    }
}
