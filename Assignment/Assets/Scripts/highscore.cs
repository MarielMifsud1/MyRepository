using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class highscore : MonoBehaviour {

    public static int player1Score;
    public static int player2Score;

    public static int hscore = 1;

    public Text player1;
    public Text player2;

    public Text winner;

    private void Start()
    {
        
    }

    private void Update()
    {
        player1.text = "Player 1 : " + player1Score;

        player2.text = "Player 2 : " + player2Score;

       
    }


}
