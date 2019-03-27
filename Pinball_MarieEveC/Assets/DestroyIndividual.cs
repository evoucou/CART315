using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyIndividual : MonoBehaviour
{
        private void OnTriggerEnter (Collider collider)
    {
            
           if(collider.gameObject.tag == "ball")     
                Destroy(gameObject);

            
}
}
