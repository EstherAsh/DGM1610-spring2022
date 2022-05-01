using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    public int numEwoks = 20;
    public int flowers = 10;
    public int frogs = 20;
    public int countup = 5;
    public int ducksInPond = 10;
    public int dogsinpark = 25;
    public int flowersinbasket = 1;
    public int flowersdestroyed = 5;
    // Start is called before the first frame update
    void Start()
    {   
        /*
        for(int i = 0; i <= numEwoks; i++)
        {
           Debug.Log("There are "+ i +" Ewoks on thelog");
        } 
        */
        /*
        for(int i = 0; i <= flowers; i++)
        {
           Debug.Log("There are "+ i +" flowers in the bouquet");
           Debug.Log("i want "+ (flowers - i) + " more flowers");
        } 
        */
        /*
        for(int i = 0; i <= frogs; i++)
        {
           Debug.Log("There are "+ i +" frogs in the bog");
        } 
        */
        /*
        for(int i = 0; i <= countup; i++)
        {
           Debug.Log(i);
        }
        */
        
        /*
        for(int i = 0; i <= dogsinpark; i++)
        {
           Debug.Log("There are "+ i +" dogs in the park");
           Debug.Log("i want "+ (flowers - i) + " more dogs to play with");
        }
        */

        /*
        while (ducksInPond >= 0)
        {
            Debug.Log(ducksInPond+ " ducks have not flown south for the winter yet");
            ducksInPond--;
        }
        */
        while (flowersinbasket <= 20 )
        {
            Debug.Log("i want more flowers! i only have " + flowersinbasket + ".");
            flowersinbasket++;
        }
        
        while (flowersdestroyed >= 0)
        {
            Debug.Log("I hate flowers! i have " + flowersdestroyed " more to destroy!!");
            flowersdestroyed--;
        }
        


        
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
