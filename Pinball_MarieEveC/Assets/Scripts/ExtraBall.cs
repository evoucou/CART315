using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraBall : MonoBehaviour
{

    public Transform[] ballSpawnPoints;
    public GameObject ballPrefab;
    public GameObject clonedBall;
    
    private FlashingText text;
    
        public float maxForce = 10;
    public float throwDistance = 10;
    private AudioSource throwSound;
    
    private void Start() {
        text = this.GetComponent<FlashingText>();
    }
    
        private void OnTriggerEnter (Collider collider)
    {
        int spawnIndex = Random.Range(0, ballSpawnPoints.Length); 
            
           if(collider.gameObject.tag == "ball") {
             text.textDisplay("+ extra ball!");
               
               
clonedBall = (GameObject) Instantiate(ballPrefab, ballSpawnPoints[spawnIndex].position, ballSpawnPoints [spawnIndex].rotation);
                
            }
            
}
}
