using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnScript : MonoBehaviour {

  // prefabs to instantiate
  public GameObject token1, token2, token3, token4;

  // spawn prefabs every 2 seconds
  public float spawnRate = 2F;

  // position of the prefab
  Vector2 whereToSpawn;

  // set next spawn time
  float nextSpawn = 0f;

  // variable containing random value
  int whatToSpawn;

  // variable containing X,Y,Z pos
  int xPos;
  int yPos;
  int zPos;

  // token position
  int tokenPos;

  // Update is called once per frame
  void Update() {
    if (Time.time > nextSpawn) { // if time has come
      // set next spawn time
      nextSpawn = Time.time + spawnRate;
      whatToSpawn = Random.Range (1,6); // define random value between 1 and 5
      whereToSpawn = Random.Range (1,5); //choose between 5 locations
      tokenPos = new Vector3 (xPos, yPos, zPos);

      // Spawn at 5 preset X and Y positions
      if (whereToSpawn == 1) {
        xPos = 0.0f;
        yPos = ;
        zPos = ;
      }
      if (whereToSpawn == 2) {
        xPos = ;
        yPos = ;
        zPos = ;
      }
      if (whereToSpawn == 3) {
        xPos = ;
        yPos = ;
        zPos = ;
      }
      if (whereToSpawn == 4) {
        xPos = ;
        yPos = ;
        zPos = ;
      }

      Debug.Log ("which token : " + whatToSpawn); // display its value in console
      Debug.Log ("where pos : " + whereToSpawn); // display its value in console

      // instantiate a prefab depending on random value
      switch (whatToSpawn) {
        case 1:
        Instantiate (token1, tokenPos, Quaternion.identity);
        break;
        case 2:
        Instantiate (token2, tokenPos, Quaternion.identity);
        break;
        case 3:
        Instantiate (token3, tokenPos, Quaternion.identity);
        break;
        case 4:
        Instantiate (token4, tokenPos, Quaternion.identity);
        break;

      }


    }

  }


}
