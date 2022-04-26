using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enums : MonoBehaviour
{

    //enum Color{blue, red, yellow, green, orange, purple};
    //constants and declaring them must be liniaer progression(lower first, etc. ) Enums can be delcared outside the class

    enum carMake{Oldmobile,Chevrolet,Ford,Mazda,Toyota,Dodge};
    enum carModel{Alero,Cruise,Tacoma,Mustang,Miata,Viper};

    //----
    enum CandleSmells{Lavendar,Citris,Mint,OldBookSmell,SeaSalt};
    enum CandleSize{twooz,eightoz,sixteenoz,twentyoz};
    enum Teams{PurpleTigers,BlueGorillas,RedRams,GreenBeetles,YellowScorpions};
    enum TeamCaptain{VladHorn,AmiePark,LilyMaeAbbott,EricStephens,AllenVance};
    enum Stats{Wisdom,Strength,Charisma,Intelligence,Dexterity,Constitution};
    enum DnDRaces{Human,Teifling,Elf,DragonBorn,Aarokocra,Dwarf};
    enum weapontypes{light,Heavy,Onehand,TwoHand,Ranged,Melee};

    // Start is called before the first frame update
    void Start()
    {
        /*
        Color paint;//variable name paint of type color.
        paint = Color.blue;//assigns paint to blue in paint.
        print(paint);
        */
        ///---

        //carMake make;
        //carModel model;
        //make = carMake.Oldmobile;
        //model = carModel.Alero;
        //print("Car manufacture: " + make + "; Model: " + model);

        //Recall(make, model);

        /*
        CandleSize Cansize;
        CandleSmells scent;
        Cansize = CandleSize.twooz;
        scent = CandleSmells.Lavendar;
        
        CandleOrder(Cansize,scent);
        */

        /*
        Teams teamname =Teams.BlueGorillas;
        TeamCaptain Captain = TeamCaptain.AmiePark;
        PlayBall(teamname, Captain);
        */

        //DnDRaces pc = DnDRaces.Teifling;
        //DND(pc);
        /*
        Stats info = Stats.Wisdom;
        Statistics(info);
        */
        /*
        weapontypes weapon = weapontypes.Onehand;
        Fight(weapon);
        */

    }

    // Update is called once per frame
    void Update()
    {

        
    }
  
    void Recall(carMake make, carModel model)
    {
        if(make ==carMake.Oldmobile && model == carModel.Alero)
        {
            print("there is a recall on your vehicle due to a faulty ignition, please take your car to the nearest dealer for repairs");
        }
        else if(make ==carMake.Ford && model == carModel.Mustang)
        {
            print("There is a recall on all Mustangs for being too cool to drive. please take it to the dealer to be made less cool.");
        }
        else
        {
            print("There is no recall notice for your vehicle make and model.");
        }
    }

    void CandleOrder(CandleSize Cansize, CandleSmells scent)
    {
        if(Cansize == CandleSize.twooz && scent == CandleSmells.Lavendar)
        {
            print("We are out of stock of " + Cansize +" size of " + scent +" candles, please try another combonation!");
        }
        else if(Cansize == CandleSize.eightoz && scent == CandleSmells.OldBookSmell)
        {
            print("We are out of stock of " + Cansize +" size of " + scent +" candles, please try another combonation!");
        }
        else
        {
            print("We are in stock of " + Cansize +" size of " + scent +" candles! Please place an order and add to cart.");
        }
    }

    void PlayBall(Teams teamname, TeamCaptain Captain)
    {
        if(teamname == Teams.PurpleTigers && Captain == TeamCaptain.VladHorn)
        {
            Debug.Log("Correct Combo! " +Captain+" does lead the team "+teamname+"!!");
        }
        else if(teamname == Teams.BlueGorillas && Captain == TeamCaptain.AmiePark)
        {
            Debug.Log("Correct Combo! " +Captain+" does lead the team "+teamname+"!!");
        }
        else if(teamname == Teams.RedRams && Captain == TeamCaptain.LilyMaeAbbott)
        {
            Debug.Log("Correct Combo! " +Captain+" does lead the team "+teamname+"!!");
        }
        else if(teamname == Teams.GreenBeetles && Captain == TeamCaptain.EricStephens)
        {
            Debug.Log("Correct Combo! " +Captain+" does lead the team "+teamname+"!!");
        }
        else if(teamname == Teams.YellowScorpions && Captain == TeamCaptain.AllenVance)
        {
            Debug.Log("Correct Combo! " +Captain+" does lead the team "+teamname+"!!");
        }  
        else
        {
            Debug.Log("Sorry, Wrong combo! "+Captain+ " does not lead the team "+ teamname+"...");
        }      
    }

    void DND(DnDRaces pc)
    {
        switch(pc)
        {
            case DnDRaces.Teifling:
             Debug.Log("the Daemons of the DND world. Have horns and vibrant skin tones(crimson, cyans, etc).");
             break;
            case DnDRaces.Human:
             Debug.Log("Average people. Their balanced stats make for good wizards and good mages. You cant go wrong with a human.");
             break;
            case DnDRaces.Elf:
             Debug.Log("High in Dexterity and Charisma, Elves often make for good spellcasters or rougues, having little to say in the strength department.");
             break;
            case DnDRaces.DragonBorn:
             Debug.Log("No one is quite sure if Dragonborn are desendants of real wyverns or a race that adapted to appear like humanoid dragons. Either case, these folk make simple work of any task and have built in fire and life magic");
             break;
            case DnDRaces.Dwarf:
             Debug.Log("The Miners of the world, Dwarves emerged from their caves not too long ago. they  dont have much to say in strength or dexterithy, but they sure are crafty little fellas (emphasis on little).");
             break;
            case DnDRaces.Aarokocra:
             Debug.Log("Bird People of the land, who often think of themsleves as higher beings to land walkers (they can fly, and often show off to their friends that they can do so.");
             break;

        }
    }

    void Statistics(Stats info)
    {
        switch(info)
        {
            case Stats.Wisdom:
             Debug.Log(" 'Street knowledge' general knowledge stuff not learned from coursework and typical education.(cultures, religions, Bodylanguage, etc");
             break;
            case Stats.Charisma:
             Debug.Log("How charming you are. This pulls from many thigns, the way you look, dress and speak are all major parts in this stat. Higher the charisma, the more likly you are of convincing someone to do what you want.");
             break;
            case Stats.Intelligence:
             Debug.Log("Book smarts that come from years of study. Things like calculations, Spells,puzzles, etc.");
             break;
            case Stats.Dexterity:
             Debug.Log("how quick and nimble you are. based on flexibility and stealth.");
             break;
            case Stats.Constitution:
             Debug.Log("How much your body can take. this is embued in things like how much health you have, how resistant you are to poisons/physical damages.");
             break;
            case Stats.Strength:
             Debug.Log("How much your body can do. Things such as lifting, carrying, and punching and others are based on this stat.");
             break;

        }
    }
    void Fight(weapontypes weapon)
    {
        if (weapon == weapontypes.TwoHand)
        {
            print("This weapon is heavy, you need two hands to handle it!");
        }
        else if (weapon == weapontypes.Onehand)
        {
            print("A light and nimble weapon, you can easily handle it with one hand.");
        }
    }
    
    

}
