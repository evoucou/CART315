using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class life : MonoBehaviour
{
int number;

    // Update is called once per frame
    void FixedUpdate()
    {
        this.GetComponent<TMPro.TextMeshPro>().text = ExtraLife.lifeNum.ToString();
    }
    
    
}
