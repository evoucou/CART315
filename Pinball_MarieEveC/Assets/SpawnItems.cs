using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItems : MonoBehaviour
{
    public Transform[] ballSpawnPoints = new Transform[4];
    public Transform[] SpawnPoints;
    public float spawnRate = 6.0f;
    public GameObject[] Tokens;
    private int[] TokenIndex;
    private int delete;
    private int oldPosition;
    
    // Start is called before the first frame update
    void Start()
    {
    TokenIndex = new int[SpawnPoints.Length];    
    InvokeRepeating ("SpawnTokens", spawnRate, spawnRate);
    delete = 0;
    }  
        
    void SpawnTokens() {
     GameObject newToken = new GameObject();
        if(delete >= TokenIndex.Length ){
            for (int i = 0; i < TokenIndex.Length; i++) 
            {         
            TokenIndex[i] = 0;
            }
            delete=0;
        }
        
    int spawnIndex = Random.Range(0, SpawnPoints.Length);
    int objectIndex = Random.Range(0, Tokens.Length);
        
       if (TokenIndex[spawnIndex] == 1)
       {
        for (int i = 0; i < TokenIndex.Length; i++) 
        {  
         if(TokenIndex[i]==0)
         {
            newToken = Instantiate (Tokens[objectIndex], SpawnPoints [i].position, SpawnPoints [i].rotation);
         }
            TokenIndex[i] =1;
            oldPosition = i;
            i=TokenIndex.Length;
        }    
       }else
       {
       newToken= Instantiate (Tokens[objectIndex], SpawnPoints [spawnIndex].position, SpawnPoints [spawnIndex].rotation);
         oldPosition = spawnIndex;
         TokenIndex[spawnIndex] =1;
       }
      
        ++delete;
        if (newToken.GetComponent<ExtraBall>() != null)
        newToken.GetComponent<ExtraBall>().ballSpawnPoints = ballSpawnPoints;

    }
}

     






