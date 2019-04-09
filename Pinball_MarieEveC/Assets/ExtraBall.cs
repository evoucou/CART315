using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraBall : MonoBehaviour
{
    
    //yellow token
    
    public Transform[] ballSpawnPoints;
    public GameObject ballPrefab;
    public GameObject clonedBall;
    //private int spawnIndex;
    //var ballPrefab : Transform
    
        public float maxForce = 10;
    public float throwDistance = 10;
    private AudioSource throwSound;
    
        private void OnTriggerEnter (Collider collider)
    {
                           int spawnIndex = Random.Range(0, ballSpawnPoints.Length);
            
           if(collider.gameObject.tag == "ball") {
           // Debug.Log("collided yellow");

  
clonedBall = (GameObject) Instantiate(ballPrefab, ballSpawnPoints[spawnIndex].position, ballSpawnPoints [spawnIndex].rotation);

                //Destroy(clonedBall, 10f);
                
            }
            
}
}