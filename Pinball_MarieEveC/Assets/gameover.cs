using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        initialposition = theball.transform.position;
        //targetInitialized = false;
    }

    // Update is called once per frame
    void Update()
    { 
        if (targetInitialized) {
            
//   void OnTriggerEnter(Collider collider) { 
//    if (collider.gameObject == xtraBall) {
//            Debug.Log("ballHit");
//            Destroy(xtraBall); 
            
            
        
    } else {
        targetInitialized = setTarget();
    }            
}
    
bool setTarget() 
{
//    test = GameObject.FindGameObjectWithTag("YellowToken");
    if(GameObject.FindGameObjectWithTag("YellowToken"))
     {
        test = GameObject.FindGameObjectWithTag("YellowToken");
        xtraBall = test.GetComponent<ExtraBall>().clonedBall;
    }   
//    xtraBall = GameObject.FindGameObjectWithTag("YellowToken").GetComponent<ExtraBall>().clonedBall;
//        
//    if (xtraBall)
//    {
//        return true;
//    }
    return false;
}
private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject == theball)
        {
            //Debug.Log("game over");
            theball.transform.position = initialposition;
            thescore.ResetScore();
            thescore.ResetMultiplier();
            
            Destroy(xtraBall);
          }  
//         else if (collider.gameObject == ballClone) {
//            Debug.Log("destroyed xtra ball"); 
//         }
    }
public
    GameObject theball;
    Score thescore;
    GameObject test;
 private
    Vector3 initialposition;
    GameObject xtraBall;  
    bool targetInitialized=false;
}
