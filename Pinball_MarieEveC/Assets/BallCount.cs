using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCount : MonoBehaviour
{
    static public int count;
    public GameObject bumperLeft;
    public GameObject bumperRight;
    public Material disabled;
    public Material bumper;
    
    private bool firstBumper;
    
    // Start is called before the first frame update
    void Start() {  
    bumperRight.GetComponent<Renderer>().material = disabled; 
    bumperLeft.GetComponent<Renderer>().material = disabled;
        
    firstBumper = false;  
    }

    // Update is called once per frame
    void FixedUpdate()
    {
         count = GameObject.FindGameObjectsWithTag("ball").Length;
    //Debug.Log("there are "+ count+ " in the game");
        print(firstBumper);
                
        if (count >= 3) {
    bumperLeft.GetComponent<Bumper>().enabled = true;
    bumperRight.GetComponent<Bumper>().enabled = true;
    bumperRight.GetComponent<Collider>().enabled = true; 
    bumperLeft.GetComponent<Collider>().enabled = true;   
    bumperRight.GetComponent<Renderer>().material = bumper; 
    bumperLeft.GetComponent<Renderer>().material = bumper;
        } else {
    bumperLeft.GetComponent<Bumper>().enabled = false;
    bumperRight.GetComponent<Bumper>().enabled = false;
    bumperRight.GetComponent<Collider>().enabled = false; 
    bumperLeft.GetComponent<Collider>().enabled = false;   
    bumperRight.GetComponent<Renderer>().material = disabled; 
    bumperLeft.GetComponent<Renderer>().material = disabled;
        }
    }
}
