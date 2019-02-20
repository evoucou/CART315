using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionToken : MonoBehaviour
{
    
    void OnCollisionEnter (Collision col)
    {
        if(col.gameObject.name == "RedToken")
        {
            Destroy(col.gameObject);
            Debug.Log("collision red");
        }
                if(col.gameObject.name == "YellowToken")
        {
            Destroy(col.gameObject);
            Debug.Log("collision yellow");
        }
    }

}
