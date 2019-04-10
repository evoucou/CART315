using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashingText : MonoBehaviour
{
private TMPro.TextMeshPro textToUse;
private GameObject a;
private MeshRenderer textMesh;

    private void Start()
    {
        a = GameObject.FindWithTag("text");
        textToUse = a.GetComponent<TMPro.TextMeshPro>();
        textMesh = textToUse.GetComponent<MeshRenderer>();
        textMesh.enabled = false;
    }

    public void textDisplay(string Text) {
        textToUse.text = Text;
 
        StartCoroutine(CountDown());    
        }
    
     public IEnumerator CountDown() {
         
        textMesh.enabled = true; 
    yield return new WaitForSeconds(3);
         textMesh.enabled = false; 
     }
 }
