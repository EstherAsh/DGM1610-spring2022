using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cargo : MonoBehaviour
{  
    [Header("health")]
    public int maxHP; 
    public int currHP; 
    public int healAmt; 
    //HPBAR
    public float gradualHeal;
    public int enemyDamage;

    [Header("Movement")]
    public float speed=3.0f;
    public float waitTime;    
    public float startWaitTime;
    public Vector2 startPoint;   

    [Header("Bounds")]
    //bounds for the movements randomly generated target to move towards
    public float maxY;
    public float minY;   
    
    void Start()
    {
        //'reset' currHP and waitTime, and creates a new target for random movement
        currHP=maxHP;   
        waitTime = startWaitTime;   
        startPoint = new Vector2(transform.position.x, Random.Range(minY,maxY));    
    }

    void Update()
    {   

        //MOVEMENT
        //sets a random Vector2 within bounds, goes towards it, waits a random interval, then sets another random Vector2
        transform.position = Vector2.MoveTowards(transform.position,startPoint, speed*Time.deltaTime);
        if (Vector2.Distance(transform.position, startPoint)<0.02f)    
        {
            if (waitTime <= 0)   
            {
                startPoint = new Vector2(transform.position.x,Random.Range(minY,maxY)); 
                waitTime = Random.Range(1,5);   
            }
            else
            {
                waitTime -= Time.deltaTime;
            }
        }

        //GRADUAL HEAL:
        //Every ten seconds, the heal funtion is run with a value of 1. if the player gets hit, this resets(resets in 'TakeDamage' funtion).
        if(gradualHeal <= 0 )
        {
            Heal(1);
            gradualHeal = 10;
        }
        else
        {
            gradualHeal -=Time.deltaTime;
        }
        
    }

    public void TakeDamage( int enemyDamage)
    {
        //subtract enemyDamage from current health, if it reaches 0, run 'Die' funtion.
        //Additionally, 'stun' them by setting wait time(interval between movements) to 5, and resetting gradual heal timer.

        currHP -= enemyDamage;
        //hpBar.SetHealth(currHP);//update health bar using current HP.
        if (currHP <=0 )
        {
            Die();
        }
        waitTime=2;
        gradualHeal=10;
    }

    public void Heal(int healAmt)
    {
        //when player picks up a heal pickup and cargo has less health then player, this function runs
        //if adding the heal amount to currHP would set currHP over maxhp, set currHP to maxHP instead.
        //if not, add healamt to currHP

        if(currHP+healAmt >=maxHP)
        {
            currHP=maxHP;
            //turn green for a split second when pickup.
        }
        else
        {
            currHP+=healAmt;
            //turn green for a split second when pickup.
        }
    }

    void Die()
    {
        //Runs when currHP is 0. does a death anim and adds 1 to the gameover counter in Gamemanager to pull up UI to restart or mainmenu.

        Debug.Log("cargoship has died");
    }

}
