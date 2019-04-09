using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraLife : MonoBehaviour
{
    
    //red token
    public static int lifeNum;
        private void OnTriggerEnter (Collider collider)
    {
        if(collider.gameObject.tag == "ball") {
    lifeNum++;                                            
}
            
    }
    

}
