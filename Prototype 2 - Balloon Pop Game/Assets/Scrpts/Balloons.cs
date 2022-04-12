using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloons : MonoBehaviour
{
    public int scoreToGive= 100; // points to give for popping ballon
    public int clicksToPop = 3; //how many clicks before the baloon pops -_-
    public float scaleToIncrease = 0.10f; //how much ballon is scaled up for clicks
    public scoremanager Scoremanager; //a variable to reference the score manager
    // Start is called before the first frame update
    void Start()
    {
        //Reference scoremanager component
        Scoremanager = GameObject.Find("scoremanager").GetComponent<scoremanager>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnMouseDown()
    {
        clicksToPop -= 1; //reduce clicks by one

        transform.localScale += Vector3.one * scaleToIncrease; //scales it up
        print(clicksToPop);
        print("aaaaaaaa");
        if(clicksToPop == 0)
        {
            print("ooooooo");
            Scoremanager.IncreaseScoreText(100);
            Destroy(gameObject);
        }
    }
}
