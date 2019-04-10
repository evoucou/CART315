using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraLife : MonoBehaviour
{
    
    //red token
    public static int lifeNum;
    private FlashingText text;
    private int index;
    
    void Start() {
        text = this.GetComponent<FlashingText>();
        index = 0;
    }
        private void OnTriggerEnter (Collider collider)
    {
        if(collider.gameObject.tag == "ball") {
    lifeNum++;
    if (index == 0) {
        text.textDisplay("+ extra life!");
            index = 1;
    }

}
            
    }
    

}
