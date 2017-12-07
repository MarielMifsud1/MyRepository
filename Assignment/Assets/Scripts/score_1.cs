using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class score_1 : MonoBehaviour {

    public Text myscore;
    int score = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (score >= 5)
        {
            SceneManager.LoadScene("Level2");
        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        score++;
        print(score);
        myscore.text = "Player 1: "+ score;

       
    }

}
