using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    static public int score = 0;
    static public int multiplier = 1;

    public TMPro.TextMeshPro multipliertext;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void FixedUpdate()
    {
        this.GetComponent<TMPro.TextMeshPro>().text = score.ToString();
        multipliertext.text = "x"+multiplier.ToString();
    }

    public void AddScore(int points)
    {
        score = score + points*multiplier;
    }

    public void Addmultiplier(int multiplierpoints)
    {
        multiplier = multiplier + multiplierpoints;
    }

}
