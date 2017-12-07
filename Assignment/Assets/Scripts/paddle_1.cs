using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle_1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        float mousePosInUnits = (Input.mousePosition.y / Screen.width * 27) - 8f;

        Vector3 newPaddlePos = new Vector3(gameObject.transform.position.x,gameObject.transform.position.y,transform.position.z);


        newPaddlePos.y = Mathf.Clamp(mousePosInUnits, -2.35f, 3.35f);

        gameObject.transform.position = newPaddlePos;

    }
}
