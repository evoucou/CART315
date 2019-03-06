using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class life : MonoBehaviour
{
int number;
    // Start is called before the first frame update
    void Start()
    {
//         number = gameObject.Find("RedToken").GetComponent<ExtraLife>().lifeNum;   
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.GetComponent<TMPro.TextMeshPro>().text = "Extra life: "+ExtraLife.lifeNum.ToString();
        //extraLife.text = "Extra life: "+life.ToString();
    }
    
}
