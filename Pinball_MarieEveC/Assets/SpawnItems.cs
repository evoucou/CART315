using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItems : MonoBehaviour
{
    public Transform[] ballSpawnPoints = new Transform[4];
      public Transform[] SpawnPoints;
    public float spawnRate = 6.0f;
    public GameObject[] Tokens;

    
    // Start is called before the first frame update
    void Start()
    {

    InvokeRepeating ("SpawnTokens", spawnRate, spawnRate);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }    
        
    void SpawnTokens() {
   int spawnIndex = Random.Range(0, SpawnPoints.Length);
    int objectIndex = Random.Range(0, Tokens.Length);
        
    GameObject newToken = Instantiate (Tokens[objectIndex], SpawnPoints [spawnIndex].position, SpawnPoints [spawnIndex].rotation);
        
        if (newToken.GetComponent<ExtraBall>() != null)
        newToken.GetComponent<ExtraBall>().ballSpawnPoints = ballSpawnPoints;
    }
}

     






