using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle_1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        float mousePos = (Input.mousePosition.x / Screen.width * 15) - 8;

        Vector3 newPaddle1Pos = new Vector3(mousePos, gameObject.transform.position.y,
                                             gameObject.transform.position.z);

        newPaddle1Pos.x = Mathf.Clamp(mousePos, -7.35f, 7.35f);

        gameObject.transform.position = newPaddle1Pos;
	}
}
