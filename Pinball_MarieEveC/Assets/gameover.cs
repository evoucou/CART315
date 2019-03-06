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
//        target = GameObject.Find("YellowToken").GetComponent<ExtraBall>().clonedBall;
    }
    

    // Update is called once per frame
    void Update()
    { 
            Debug.Log("num lives: "+ExtraLife.lifeNum);
}
    
private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "ball")
        {
//                       collider.gameObject.transform.position = initialposition;
        //if ballCount = 1
            
            Destroy(collider.gameObject);
            
            //Debug.Log("game over");
            if (ExtraLife.lifeNum == 0) {
            Score.score = 0;
            Score.multiplier = 1;
   //Destroy(target);
            //GameObject.Destroy(target); 
            } else {
                ExtraLife.lifeNum--;
            }
          }  
//         else if (collider.gameObject == ballClone) {
//            Debug.Log("destroyed xtra ball"); 
//         }
    }
    
    public void instantiateXtraBall() {

    }

public
    GameObject theball;
    //Score thescore;
    //GameObject test;
    
 private
    Vector3 initialposition;
    //bool xtraBall;  
    //bool targetInitialized=false;
    //GameObject target;
}
