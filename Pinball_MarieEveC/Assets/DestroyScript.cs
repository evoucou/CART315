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
    
    void OnCollisionEnter (Collision col)
    {
        if(Time.time < destroyTime) {
            Destroy(gameObject);
            Debug.Log("collision");
        }
    }
        
    
    void Update() {
        transform.Rotate (Vector3.right * Time.deltaTime * rotateSpeed);
    }
}
