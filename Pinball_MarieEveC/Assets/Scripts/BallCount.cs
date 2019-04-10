using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallCount : MonoBehaviour
{
    static public int count;
    public GameObject bumperLeft;
    public GameObject bumperRight;
    
    public Material disabled;
    public Material bumper;
    
    public string button = "Reset";
    private FlashingText text;

    // Start is called before the first frame update
    void Start() {  
    bumperRight.GetComponent<Renderer>().material = disabled; 
    bumperLeft.GetComponent<Renderer>().material = disabled; 
        
    text = this.GetComponent<FlashingText>();
        
    if (count >= 3) text.textDisplay("Don't lose your balls!"); 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
         count = GameObject.FindGameObjectsWithTag("ball").Length;
                
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
            
  if(Input.GetKeyDown(KeyCode.R))
               SceneManager.LoadScene("pinball");

         }
    }


