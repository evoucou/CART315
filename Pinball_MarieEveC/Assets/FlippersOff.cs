using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlippersOff : MonoBehaviour
{
    
    private GameObject[] flippers;
    private float timer;
    private float waitTime = 5.0f;
    private bool targetHit;
    
    void Start()
    {
       targetHit = false;
       flippers = GameObject.FindGameObjectsWithTag("flipper");
       timer = 0;
    }

    void FixedUpdate() {
        //Debug.Log("targetHit : " + targetHit);
        
        if (targetHit) {    
        //starting timer
        timer += Time.deltaTime;
            Debug.Log("targetHit");
            
        foreach (GameObject flipper in flippers) {
              if (timer < waitTime) {
                Debug.Log("flippers deactivated"); 
                  //Deactivating the flipper script that makes them move
                flipper.GetComponent<Flipper>().enabled = false;
             } else {
                Debug.Log("flippers activated"); 
                flipper.GetComponent<Flipper>().enabled = true;
                //Resets settings til the next collision
                timer = 0;
                targetHit = false;
             }
            }
        }
    }
    
            private void OnTriggerEnter (Collider collider) {        
           //if collision with ball
            if(collider.gameObject.tag == "ball") {
                
            //Destroy token
            Destroy(gameObject);
           
            Debug.Log("Collision blue");
            targetHit = true;
                    
            }    
        }
}
