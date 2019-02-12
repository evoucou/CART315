using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// class within a class eg Person with a student Id
//public class Student : Person{
//	public int ID;
//}
// Monobehavoiur is a subclass of the class Components and has all the Unity scipts
public class rotateCube : MonoBehaviour {
	public float rotateSpeed = 1.5f;
//	public string secret = "this is a secret string";

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	//use fixed update to get 60fps
	void Update () {
		this.transform.Rotate(0, rotateSpeed, 0);
	}
}
