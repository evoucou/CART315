using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionToken : MonoBehaviour
{  
    
    private GameObject[] flippers;
    private int timer;
    
    private AudioSource[] audios;
    public AudioClip[] clips;
        
    public Material currMaterial;
    public Material disabled;

    
    void Start()
    {
       flippers = GameObject.FindGameObjectsWithTag("flipper");
       timer = 0;  
        
        audios = GetComponents<AudioSource>();
        audios[0].clip = clips[0];
        audios[1].clip = clips[1];
        
    }
    
            private void OnTriggerEnter(Collider collider) {        
           //if collision with ball
            if(collider.gameObject.tag == "RedToken" || collider.gameObject.tag == "token") {
            Destroy(collider.gameObject);
            audios[0].PlayOneShot(clips[0]);
                
                                
            if(collider.gameObject.tag == "RedToken") {
                
            audios[1].PlayOneShot(clips[1]);
            InvokeRepeating("CountDown", 1, 1);
        
           
            foreach (GameObject flipper in flippers) {
                flipper.GetComponent<Flipper>().enabled = false;  
                flipper.GetComponent<Renderer>().material = disabled; 
                }
            } 
            }
   
        }
    
 public void CountDown() {
     if (timer < 5) {
    timer++;
    }
    else {
         audios[1].Stop();
        
    foreach (GameObject flipper in flippers) {
    flipper.GetComponent<Renderer>().material = currMaterial; 
    flipper.GetComponent<Flipper>().enabled = true; 
    }

    CancelInvoke(); // Stops all repeating invokes
    timer = 0;

     }
 }
    
}
