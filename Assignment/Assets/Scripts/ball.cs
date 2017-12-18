using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class ball : MonoBehaviour
{

    paddle_1 paddle;
    Vector3 ballPaddleDiff;
    public static bool gameStarted = false;
    Vector3 ballPos;
    

    // Use this for initialization
    void Start()
    {
        ballPos = transform.position;
        paddle = GameObject.FindObjectOfType<paddle_1>();

        ballPaddleDiff = this.transform.position - paddle.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        

        if (Input.GetMouseButtonDown(0))
        {
            
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(10f, 11f);
            this.GetComponent<Rigidbody2D>().AddForce(transform.forward);
        }

        if (!gameStarted) 
        {
            gameObject.transform.position = ballPos;
        }

        if (Input.GetMouseButtonDown(0) && !gameStarted)
        {
            gameStarted = true;
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);
            


        }
    }

   
}
