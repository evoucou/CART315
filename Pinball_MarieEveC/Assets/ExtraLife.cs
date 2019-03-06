using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraLife : MonoBehaviour
{
    
    //red token
    public static int lifeNum;
    
    // Start is called before the first frame update
    void Start()
    {
         
    }
    void update() {
                   
    }
    
        private void OnTriggerEnter (Collider ball)
    {
        if(ball.name == "Ball") {
                
                Destroy(gameObject);
            Debug.Log("collided red");
            lifeNum++;
            
                                          
}
            
    }
    

}
