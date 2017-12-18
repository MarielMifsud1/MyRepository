using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle_2 : MonoBehaviour {

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time, 3), transform.position.z);

        // this will go back and forth between 0 and the lenght 
    }
}
