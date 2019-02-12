using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{
    public Score bumpScore;
  private int timer = 0;
  private Vector3 scaleMod;
    // Start is called before the first frame update
    void Start()
    {
scaleMod = this.transform.localScale;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
      if (timer == 0)
      {
this.transform.localScale = scaleMod;

      } else
      {
timer--;
      }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (timer == 0)
        {
            bumpScore.AddScore(5);
            bumpScore.AddMultiplier();
        }

        this.GetComponent<AudioSource>().Play();
this.transform.localScale = scaleMod * 1.5f;
timer = 9;

    }
}
