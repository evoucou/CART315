using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AddScore : MonoBehaviour
{

    int score = 0;
    int multiplier = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.GetComponent<TextMeshPro>().text = score.ToString();
    }

    public void AddScore(int points) 
    {
        score = score + points * multiplier;
      }

    public  AddMultiplier(int multiplierpoints)
    {
        multiplier = multiplier + multiplierpoints;

    }

    public void ResetScore() 
    {
        score = 0;
      }

    public void ResetMultiplier()
    {
        multiplier = 1;

    }
}
