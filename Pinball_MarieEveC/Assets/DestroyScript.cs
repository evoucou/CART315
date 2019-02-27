using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyScript : MonoBehaviour
{
    public float destroyTime = 20.0f;
      public float rotateSpeed = 600.0f;
    
    //public bool redTokenActive = false;
    //public bool yellowTokenActive = false;
    
    // Start is called before the first frame update
    void Start() {
            Destroy (gameObject, destroyTime);    
    }
        
    
    void Update() {
        transform.Rotate (Vector3.right * Time.deltaTime * rotateSpeed);     
    }
    
        
//            if(gameObject.name == "RedToken" || gameObject.name == "RedToken(Clone)") {
//                
//                Destroy(gameObject);
//            //Debug.Log("collision Red");
//                //redTokenActive = true;
//                                          }
//       if(gameObject.name == "YellowToken" || gameObject.name == "YellowToken(Clone)") {
//           
//                Destroy(gameObject);
//            //Debug.Log("collision Yellow");
//           //yellowTokenActive = true;
//                                          }
//        }
            
    
    

}
