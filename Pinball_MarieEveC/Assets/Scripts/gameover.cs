using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameover : MonoBehaviour
{

    private Vector3 initialposition;
    public GameObject initialObj;
    
    // Start is called before the first frame update
    void Start()
    {
        initialposition = initialObj.transform.position;
    }

    
private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "ball") {
                     
                if (ExtraLife.lifeNum == 0) {
            Score.score = 0;
            Score.multiplier = 1;
            }
            
            if(BallCount.count > 1){
            Destroy(collider.gameObject);
            Score.multiplier = 1;
            }            
            else if (BallCount.count == 1){
            if (ExtraLife.lifeNum > 0)
                ExtraLife.lifeNum--; 
                
            collider.gameObject.transform.position = initialposition;
            Score.multiplier = 1;
          } 
        }
    }

}
