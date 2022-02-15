using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{

    public string[] FriendNames = {"Bob" , "Jessica" , "Jody" , "Arthur" , "Randall" , "Todd" , "Becky"};
    public float[] Grades = {81.5f,91.9f,99.9f,57.3f,90.0f,69.7f};
    public int[] numbers = {12,43,4,56,23,11,50,3};
    public string[] simpleinv = {"Sword", "magic orb" , "12 food rations" , "another sword" , "rope" , "torch" , "crossbow" , "another another sword" , "fire gummis"};
    public bool[] TrueFalseTestAwnsers = {true,false,true,true,false,false,false,true,false,true,false,true};
    public int[] agesoffam = {16,19,23,26,29,31,48,51};
    public string[] letters = {"a" , "b" , "c" , "d" , "e" , "f" , "g" , "h" , "i" , "j" , "k" , "l" , "m" , "n" , "o" , "p" , "q" , "r" , "s" , "t" , "u" , "v" , "w" , "x" , "y" , "and" , "z" };
    public string[] fullname = {"Esther", "Maria", "Ashby"};
    public int[] booknumbs = {132,633,472,685,203,111,560,300};
    public float[] testscores = {99.9f,97.2f,68.8f,87,09f,100.0f,75,6f};
    // Start is called before the first frame update
    void Start()
    {
        /*
        Debug.Log("Former friend : " + FriendNames[0]);
        Debug.Log(FriendNames[3]+ "Says Hi as they walk to class");
        FriendNames[0]="Veronica";
        Debug.Log ("new friend : "+ FriendNames[0]);
        */
        

        /*
        foreach(int numbers in numbers)
        {
            print(numbers);

        }
        */

        /*
        foreach (string FriendNames in FriendNames)
        {
            print(FriendNames);
        }
        */
        print ("Your inventory is as follows:");
        foreach (string simpleinv in simpleinv)
        {
            
            print(simpleinv);
            
            
        }
        print("You are holding too many swords and are over encumbered. you cannot sprint while over-encumbered.");
        /*
        foreach (bool TrueFalseTestAwnsers in TrueFalseTestAwnsers)
        {
            print("here are your test awnsers.");
            print(TrueFalseTestAwnsers);
        }
        

        print ("Lets sing the ABCs!");
        foreach (string letters in letters)
        {
            print ("Lets sing the ABCs!");
            print(simpleinv);
            
            
        }
        print ("now i know my ABCs next time wont you sing with me?")
        */



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

