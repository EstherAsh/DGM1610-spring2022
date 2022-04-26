using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour
{
    //public string npcConvo;
    //public int SocialClass;

    //[Header("Input Codename:")]
    //public string CharDesc;
    //public int Charstats;
    //public char grade;
    //public int Inventory;
    //public string FullName;
    //public int age;
    //public string clocktime;
    //public int score;
    //public string lastone;
    void Start()
    {
 
        /*
        switch(npcConvo)
        {
            case "Hello":
             print("Hellow good citizen! May the blessings of Zandar be upon ye!");
             break;
            case "Goodbye":
             print ("Fare thee well! And safe travels to you and your party");
             break;
            case "We are being attacked, HELP":
             print("You run away in shame, coward!");
             break;
        }
        */
        ///----------
        /*
        switch(SocialClass)
        {   case 1:
             Debug.Log("Greetings your Majesty");
             break;
            case 2:
             Debug.Log("Hello your Grace");
             break;
            case 3:
             Debug.Log("Good evening your Excellence");
             break;
            case 4:
             Debug.Log("Hello Mr.Mayor!");
             break;
            case 5:
             Debug.Log("Hey dude wassup?");
             break;
            case 6:
             Debug.Log("street rat, how dare you look at me!");
             break;
            default:
             Debug.Log("I dont talk to strangers");
             break;
        }
        */
        ////-------

        /* 
       switch(CharDesc)
       {    case("Tuner"):
             Debug.Log("Being far from home, and accidentally pulled into this spaceship rebellion, The Tuner, or 'Mechi', was a spaceship repairman who accidentally got abducted by the rebellion and found his place there. He doesnt really know what is happening with the rebellion, but as long as he has a solid string of work, hes fine.");
             break;
            case ("Veteran"):
             Debug.Log("The best way to describe Victorya is wise from expierence. she is one of the eldest in the rebellion, and has seen her fair share of spaceship battles. She will stop at nothing untill her planet, Vadras, is safe from evil hands. She is fierce and can seem cold-hearted at times, but in reality shes just dedicated her life to protecting her planet she hasnt had time to protect herself.");
             break;
            case ("OP"):
             Debug.Log("When the rebellion reached out to recuits, at the bottom of the list was Zelda. She played and streamed video games, and was a bit of an internet personality before the rebellion formed. She had the highest scores by far on a spaceship simulator game. The rebellion was hesitant, but desperate for requits so they reached out. Much to their surprise, Codename 'OP' was, in fact, overpowered. she quickly grew through the ranks to become one of, if not the best pilots the rebellion has seen. ");
             break;
            case ("Hotshot"):
             Debug.Log("Title:Hotshot, name:Engine. He is a young adult, freshly graduated from Vadras's Interplanetary Flight School, and ready to show the world who he is. He has a large ego, but skills to back him up (he was the valedictorian of his year in flight school). He wants nothing more than to be seen by the world as a hero, saving people, flirting with girls, yknow, hero stuff. He might seem cocky and rude, but underneath that is a dude who just wants to be seen.");
             break;
            case ("Prodigy"):
             Debug.Log("Kandi is the youngest pilot the rebellion has seen, ever. She is a 14 year old kid, who is very much into 14 year old girl things, but that doesnt stop her from being one of the most skilled pilots around. She is constantly being undersold to her peers becuase of her age and her interests, and she wants nothing more than to be seen as what she is: A pilot, and a 14 year old, not one or the other, but both.");
             break;
            default:
             Debug.Log("Insert the Codename, "Prodigy, Hotshot, Veteran, OP, or Tuner to see their description on file.");
        }
        */
        ///-------
        /*
        switch(Charstats)
       {    case 1:
             Debug.Log("Tuner stats: INT8, WIS 4, STR 7, CHAR8");
             break;
            case 2:
             Debug.Log("Veteran stats: INT 4; WIS 9, STR 8, CHAR 5");
             break;
            case 3:
             Debug.Log("OP stats: INT 4, WIS 7, STR 4, CHAR 9");
             break;
            case 4:
             Debug.Log("Hotshot stats: INT 3, WIS 9, STR 3, CHAR 9");
             break;
            case 5:
             Debug.Log("Prodigy stats: INT 4, WIS 7, STR 4, CHAR 8");
             break;
            default:
             Debug.Log("Insert Chars number to see their stats (TUNER-1, VETERAN-2, OP-3, HOTSHOT-4, PRODIGY-5)");
             break;
        }
        */
        ////-------
        /*
        switch(grade)
       {    case a:
             Debug.Log("You got an A! you aced this course, perfect score!");
             break;
            case b:
             Debug.Log("You got a B, almost perfect! good job");
             break;
            case c:
             Debug.Log("You got a C, you passed this course, not bad!");
             break;
            case d:
             Debug.Log("You got a D, you can try again and do better");
             break;
            case f:
             Debug.Log("You failed this class, please try again!");
             break;
            default:
             Debug.log("please enter score")
        }
        */
        ///------
        /*
        switch(Inventory)
        {    case 0:
             print("You have a sword in inventory slot 0");
             break;
            case 1:
             print("You have a health in inventory slot 1");
             break;
            case 2:
             print("You have a bow in inventory slot 0");
             break;
            case 3:
             print("You have 17 arrows in inventory slot 0");
             break;
            case 4:
             print("You have 32 GP in inventory slot 0");
             break;
            default:
             print("Please enter the inventory slot you wish to check (0-4)");
             break;
        } 
        */ 
        /////------
        /*
        switch(FullName)
        {    case ("Nathaniel"):
             print("Nathan, Nate");
             break;
            case ("Micheal"):
             print("Mike");
             break;
            case ("Isabella"):
             print("Bella, Bell");
             break;
            case ("Robert"):
             print("Rob, Bob, Bert");
             break;
            case ("Franklin"):
             print("Frank");
             break;
            default:
             print("Please enter a vaild name so we can assign a nickname");
             break;
        } 
        */
        //////--------
        /*
        switch(age)
        {    case 0:
             print("You are too young!");
             break;
            case 5:
             print("You are a kid!");
             break;
            case 13:
             print("you are a teenager");
             break;
            case 21:
             print("You are an adult");
             break;
            default:
             print("you have an age we havent accounted for.");
             break;
        } 
        */
        //////-------
        /*
        switch(clocktime)
        {    case ("1AM"):
             print("You should be asleep");
             break;
            case ("5AM"):
             print("its still to early, go back to bed");
             break;
            case ("9AM"):
             print("I wish i could go back to bed");
             break;
            case ("Noon"):
             print("its late, im going back to bed");
             break;
            default:
             print("go to bed!");
             break;
        } 
        */
        ////-----
        /*
        switch(score)
        {    case 100:
             print("You aced the test!");
             break;
            case 85:
             print("You pased the test and got a B");
             break;
            case 75:
             print("You passed the test");
             break;
            case 50:
             print("You failed the test :(");
             break;
            default:
             print("please round your score to 100, 85, 75, 50");
             break;
        }
        */
        ///-----
        /*
        switch(lastone)
        {    case firstone:
             print("this was the first one i made! ");
             break;
            case middleone:
             print("im getting better, heres the middle one");
             break;
            case lastone:
             print("Ive perfected the formula, here is the last ");
             break;
            default
             print("please enter firstone, middleone or the last one to recieve science notes");
             break;
        }
        */








    }

}
