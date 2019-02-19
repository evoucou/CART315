using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public GameObject spawnee;
    //public bool stopSpawning = false;
    public float spawnDuration;
    public float spawnDelay;
    public bool tokenOnGame = false;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnObject", spawnDuration);

        if (tokenOnGame == false)
        {
            CancelInvoke("SpawnObject");
        }
 
    }

        public void SpawnObject()
    {
        Instantiate(spawnee, transform.position, transform.rotation);
    }
    // Update is called once per frame
    void Update()
        {
        Debug.Log("tokenongame : " + tokenOnGame);
    }

    private void OnCollisionEnter(Collision collision)
    {
        CancelInvoke("SpawnObject");
        tokenOnGame = false;
        Debug.Log("Collision ball");

    }
}
