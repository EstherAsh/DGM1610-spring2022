using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCalc : MonoBehaviour
{
    //access modifier Data Name of variable (optional) = assigned value;
    //^variable template

    public int NumberA = 1;
    public int NumberB = 2;
    public int NumberC = 3;
    

    // Start is called before the first frame update
    void Start()
    {
        add();
        sub();
        mult();
        div();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void add()   
    {
        int total;
        total = NumberA + NumberB;
        Debug.Log(NumberA + " + " + NumberB + " = " + total);
    }
    void sub()   
    {
        int total;
        total = NumberB - NumberC;
        Debug.Log(NumberB + " - " + NumberC + " = " + total);
    }
    void mult()   
    {
        int total;
        total = NumberB * NumberB;
        Debug.Log(NumberB + " x " + NumberB + " = " + total);
    }
    void div()   
    {
        int total;
        int rem;
        total = NumberB / NumberA;
        rem = NumberB % NumberB;    
        Debug.Log(NumberB + " / " + NumberA + " = " + total + "."+ rem);
    }

}
