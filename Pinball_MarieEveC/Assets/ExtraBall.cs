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
        //spawnIndex = Random.Range(0, SpawnPoints.Length);
        // change color of extra ball so we know which one
        //xtraBall.GetComponent<SpriteRenderer>().color = Color.red;
//        ballSpawnPoints[0] = GameObject.Find("BallPoint1");
//        ballSpawnPoints[1] = GameObject.Find("BallPoint2");
//        ballSpawnPoints[2] = GameObject.Find("BallPoint3");
//        ballSpawnPoints[3] = GameObject.Find("BallPoint4");

    }

    
    
        private void OnTriggerEnter (Collider col)
    {
                           int spawnIndex = Random.Range(0, ballSpawnPoints.Length);
            
           if(col.name == "Ball") {
                 Debug.Log("Before the clone is created. Spawn = " + spawnIndex);  
              
                
                Destroy(gameObject);
           // Debug.Log("collided yellow");

  
clonedBall = (GameObject) Instantiate(ballPrefab, ballSpawnPoints[spawnIndex].position, ballSpawnPoints [spawnIndex].rotation);
                
Debug.Log("After the clone is created. Spawn = " + spawnIndex);
                
                Destroy(clonedBall, 10f);
                
            }
            
}
}