using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraBall : MonoBehaviour
{
    
    //yellow token
    
    public Transform[] SpawnPoints;
    public GameObject ballPrefab;
    public GameObject clonedBall;
    //var ballPrefab : Transform
    
    
    // Start is called before the first frame update
    void Start()
    {
        // change color of extra ball so we know which one
        //xtraBall.GetComponent<SpriteRenderer>().color = Color.red;

    }


    
        private void OnTriggerEnter (Collider col)
    {
            if(col.name == "Ball") {
                int spawnIndex = Random.Range(0, SpawnPoints.Length);
                
                Destroy(gameObject);
           // Debug.Log("collided yellow");
                
clonedBall = (GameObject) Instantiate(ballPrefab, SpawnPoints [spawnIndex].position, SpawnPoints [spawnIndex].rotation);
                
            }
            
}
}