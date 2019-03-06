using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCount : MonoBehaviour
{
    static public int count;
    // Start is called before the first frame update
    void Start()
    {
//ballCount = 1;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
         count = GameObject.FindGameObjectsWithTag("ball").Length;
    //Debug.Log("there are "+ count+ " in the game");   
    }
}
