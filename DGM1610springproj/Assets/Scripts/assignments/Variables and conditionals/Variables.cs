using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    //global variables
    public int money;// whole number value. can be pos or neg
    public float change = .75f; //floating point number or decimal, such as 2.4, or 17.98-- when declared has to have an f on the end 
    public bool isday = true; //true or false .
    public string login = "bob234"; // string is text alphanumerical, ALWAYS in qoutation marks when declaring.
    // Start is called before the first frame update
    void Start()
    {
        print(money);
    }

    // Update is called once per frame
    void Update()
    {
        if(isday)
        {
            print("it is day"); 
        }
        else if (isday == false)
        {
            print("it is not day");
        }
    }
}
