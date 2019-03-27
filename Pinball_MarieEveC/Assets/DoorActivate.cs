using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorActivate : MonoBehaviour
{
    public GameObject[] doors;
    private bool isUp;
    //private bool isDown;
    
    void Start() {
        isUp = false;
        //isDown = true;
    }
    
    // Start is called before the first frame update
    void OnCollisionExit(Collision collider) {
        
        if(collider.gameObject.tag == "ball") {
            
        if (isUp == false) {
        foreach (GameObject door in doors) {
        // doors activated
        door.transform.position += new Vector3(0f, 0.5f, 0f);
       isUp = true;
            }
        } else {
        foreach (GameObject door in doors) {
        // doors deactivated
        door.transform.position += new Vector3(0f, -0.5f, 0f);  
        isUp = false;
                }     
            }
        }
    }
}