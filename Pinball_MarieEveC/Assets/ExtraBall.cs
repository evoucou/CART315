using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraBall : MonoBehaviour
{
    
    //yellow token
    
    public Transform[] SpawnPoints;
        public GameObject xtraBall;
    
    
    // Start is called before the first frame update
    void Start()
    {
        // change color of extra ball so we know which one
        xtraBall.GetComponent<SpriteRenderer>().color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {

    }

    
        private void OnTriggerEnter (Collider ball)
    {
            if(ball.name == "Ball") {
                int spawnIndex = Random.Range(0, SpawnPoints.Length);
                
                Destroy(gameObject);
            Debug.Log("collided yellow");
                
Instantiate(xtraBall, SpawnPoints [spawnIndex].position, SpawnPoints [spawnIndex].rotation);
            }
}
            
}