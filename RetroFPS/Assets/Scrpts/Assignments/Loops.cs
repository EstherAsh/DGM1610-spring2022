using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    //public int numEwoks = 20;
    public int ducksInPond=10;
    // Start is called before the first frame update
    void Start()
    {
        /*
       for(int i = 0; i <= numEwoks; i++)
       {
           Debug.Log("There are "+ i +" Ewoks on thelog");
       } 
       */
        while (ducksInPond >= 0)
        {
            Debug.Log(ducksInPond+ " ducks have not flown south for the winter yet");
            ducksInPond--;
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
