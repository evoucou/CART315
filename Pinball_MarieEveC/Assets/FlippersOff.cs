using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlippersOff : MonoBehaviour
{
    
    private GameObject[] flippers;
    private int timer;
    //private bool targetHit;
    
    void Start()
    {
       //targetHit = false;
       flippers = GameObject.FindGameObjectsWithTag("flipper");
       timer = 0;     
        //redToken = 
    }
    
            private void OnTriggerEnter(Collider collider) {        
           //if collision with ball
            if(collider.gameObject.tag == "redToken") {
                
            //Destroy token
                
            InvokeRepeating("CountDown", 1, 1);
           
            foreach (GameObject flipper in flippers)
                flipper.GetComponent<Flipper>().enabled = false;  
                
            }    
        }
    
 public void CountDown() {

         if (timer < 5) {
    timer++;
    }
    else {
         Debug.Log("flippers reactivated");
    foreach (GameObject flipper in flippers)
        flipper.GetComponent<Flipper>().enabled = true; 
        
    CancelInvoke(); // Stops all repeating invokes
    timer = 0;

     }
   }
}
