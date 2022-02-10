using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloons : MonoBehaviour
{
    public int scoreToGive; // points to give for popping ballon
    public int clicksToPop = 3; //how many clicks before the baloon pops -_-
    public float scaleToIncrease = 0.10f; //how much ballon is scaled up for clicks

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnMouseDown()
    {
        clicksToPop -= 1; //reduce clicks by one

        transform.localScale += Vector3.one * scaleToIncrease; //scales it up
    }
}
