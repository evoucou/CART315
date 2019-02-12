using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetBall : MonoBehaviour
{

private Vector3 initialPosition;
public GameObject theball;
public Score bumpScore;
{
    // Start is called before the first frame update
    void Start()
    {
    initialPosition = theball.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

private void OnCollisionEnter(Collider collider)
{ 
    if (collider.gameObject == theball) {
       theball.transform.position = initialPosition;
            bumpScore.ResetScore();
            bumpScore.ResetMultiplier();
    }
}
}
