using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraLife : MonoBehaviour
{
    
    //red token
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    
        private void OnTriggerEnter (Collider ball)
    {
        if(ball.name == "Ball") {
                
                Destroy(gameObject);
            Debug.Log("collided red");
                                          
}
            
    }
}
