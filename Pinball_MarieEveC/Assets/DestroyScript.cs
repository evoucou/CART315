using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyScript : MonoBehaviour
{
    public float destroyTime = 6.0f;
      public float rotateSpeed = 600.0f;
    
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
            Destroy(gameObject);
            Debug.Log("collision");
        }
            
    }

}
