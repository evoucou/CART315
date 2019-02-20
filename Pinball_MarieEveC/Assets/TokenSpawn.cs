using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TokenSpawn : MonoBehaviour
{

  public Transform[] SpawnPoints;
    public float spawnRate = 3f;
    public GameObject[] Tokens;
    
    
//    // prefabs to instantiate
//  //public GameObject token1, token2, token3;
//
//  // spawn prefabs every 2 seconds
//  float spawnRate = 3f;
//
//  // position of the prefab
//  int whereToSpawn;
//
//  // set next spawn time
//  float nextSpawn = 0f;
//    
//// how long the tokens are on the game for
//    //float spawnTime = 6f;
//    
//
//  // variable containing random value
//  int whatToSpawn;
//
//  // variable containing X,Y,Z pos
//  float xPos;
//  float yPos;
//  float zPos;
//
//  // token position
//  Vector3 tokenPos;
    
    void Start() {
        InvokeRepeating ("SpawnTokens", spawnRate, spawnRate);
    }

  // Update is called once per frame
  void Update() {
      
//    if (Time.time > nextSpawn) { // if time has come
//      // set next spawn time
//      nextSpawn = Time.time + spawnRate;
//      whatToSpawn = Random.Range (1,3); // define random value between 1 and 5
//      whereToSpawn = Random.Range (1,5); //choose between 5 locations 
//    
//
//      Debug.Log ("which token : " + whatToSpawn); // display its value in console
//      Debug.Log ("where pos : " + whereToSpawn); // display its value in console
//Debug.Log("token1: "+ token1.transform.position);
//        
//        tokenPos = new Vector3 (xPos, yPos, zPos);
//        transform.position = tokenPos;
//        
//        xPos = Random.Range();
//        yPos = Random.Range();
//        
//        
////              switch (whereToSpawn) {
////        case 1:
////        xPos = -3.12f;
////        yPos = -0.81f;
////        zPos = 0.03f;
////        break;
////        case 2:
////        xPos = 0.05f;
////        yPos = 0.08f;
////        zPos = -1.38f;
////        break;
////        case 3:
////        xPos = 2.33f;
////        yPos = 0.71f;
////        zPos = 2.55f;
////        break;        
////        case 4:
////        xPos = 3.15f;
////        yPos = 0.92f;
////        zPos = 0.55f;
////        break;
////        case 5:
////        xPos = -1.88f;
////        yPos = -0.49f;
////        zPos = 1.97f;
////        break;
////
////      }
//        
//      // instantiate a prefab depending on random value
//      switch (whatToSpawn) {
//        case 1:
//       token1.SetActive(true);
//        token2.SetActive(false);
//        token3.SetActive(false);
//        break;
//        case 2:
//       token2.SetActive(true);
//        token1.SetActive(false);
//        token3.SetActive(false);
//        break;
//        case 3:
//       token3.SetActive(true);
//        token1.SetActive(false);
//        token2.SetActive(false);
//        break;
//
//      }
//
//
//    }

  }
    
    void SpawnTokens() {
        int spawnIndex = Random.Range(0, SpawnPoints.Length);
        int objectIndex = Random.Range(0, Tokens.Length);
        
        Instantiate (Tokens[objectIndex], SpawnPoints [spawnIndex].position, SpawnPoints [spawnIndex].rotation);
    }


}
