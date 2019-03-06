using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TokenSpawn : MonoBehaviour
{
    
  public Transform[] SpawnPoints;
    public float spawnRate = 3f;
    public GameObject[] Tokens;
    
    
    void Start() {
        InvokeRepeating ("SpawnTokens", spawnRate, spawnRate);
    } 

  // Update is called once per frame
  void Update() {


  }
    
    void SpawnTokens() {
        int spawnIndex = Random.Range(0, SpawnPoints.Length);
        int objectIndex = Random.Range(0, Tokens.Length);
        
        Instantiate (Tokens[objectIndex], SpawnPoints [spawnIndex].position, SpawnPoints [spawnIndex].rotation);
    }


}
