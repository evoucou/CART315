using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class launcher : MonoBehaviour {
	// press a to move flipper
	//turn on motor
	// Use this for initialization

	public string button = "launch";

	void Start () {

	}

	// Update is called once per frame
	void FixedUpdate () {
		// whether button is pressed or not this is called the branch
		if (Input.GetButton (button)) {
			//check the use motor when any key is pressed
			this.GetComponent<ConstantForce>().enabled = true;	
		} 
		else {
			//uncheck the use motor when no key is pressed
			this.GetComponent<ConstantForce>().enabled = false;	
		}

	}
}
