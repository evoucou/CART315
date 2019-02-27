using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyScript : MonoBehaviour
{
    public float destroyTime = 6.0f;
      public float rotateSpeed = 600.0f;
    
    public bool colRedToken = false;
    public bool colYellowToken = false;
    
    // Start is called before the first frame update
    void Start() {
            Destroy (gameObject, destroyTime);
    }
        
    
    void Update() {
        transform.Rotate (Vector3.right * Time.deltaTime * rotateSpeed);
    }
    
        
    private void OnTriggerEnter (Collider ball)
    {
        if(ball.name == "Ball")
        {
            if(gameObject.name == "RedToken" || gameObject.name == "RedToken(Clone)") {
                Destroy(gameObject);
            Debug.Log("collision Red");
                
                colRedToken = true;
                                          }
       if(gameObject.name == "YellowToken" || gameObject.name == "YellowToken(Clone)") {
                Destroy(gameObject);
            Debug.Log("collision Yellow");
           
           colYellowToken = true;
                                          }
        }
            
    }

}
