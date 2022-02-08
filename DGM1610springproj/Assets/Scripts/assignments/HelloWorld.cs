using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//^grabbing info from library of commands
//v within brackets is a class.  where helloworld is HAS to be the same as filename.
public class HelloWorld : MonoBehaviour
{
    // Start is called before the first frame update
    //within a unity VScode file, it has start and update. start happens once
    //update happens once per frame.
    void Start()
    {
        print("hello world");
        //^always end statements with semicolon.
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
