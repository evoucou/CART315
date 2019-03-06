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
    
    
    // Start is called before the first frame update
    void Start()
    {
    }

    
    
        private void OnTriggerEnter (Collider collider)
    {
                           int spawnIndex = Random.Range(0, ballSpawnPoints.Length);
            
           if(collider.gameObject.tag == "ball") {
              
                
                Destroy(gameObject);
           // Debug.Log("collided yellow");

  
clonedBall = (GameObject) Instantiate(ballPrefab, ballSpawnPoints[spawnIndex].position, ballSpawnPoints [spawnIndex].rotation);

                //Destroy(clonedBall, 10f);
                
            }
            
}
}