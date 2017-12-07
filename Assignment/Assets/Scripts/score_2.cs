using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class score_2 : MonoBehaviour {

    public Text myscore2;
    int score2 = 0;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (score2 >= 5)
        {
            SceneManager.LoadScene("Level2");
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        score2++;
        print(score2);
        myscore2.text = "Player 2: " + score2;

        
    }
}
