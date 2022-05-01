using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageBoost : MonoBehaviour
{

    //this exists to have a seperated Update function to do a timer for the attack boost.
    public PlayerController player;
    float damageBoostDuration;
 
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        damageBoostDuration = 10.0f;
        player.playerDamage +=10;
    }

    void Update()
    {

        if(damageBoostDuration >0)
        {
            
            damageBoostDuration -=Time.deltaTime;
        }
        else
        {
            damageBoostDuration=0;
            player.playerDamage -=10;
            Destroy(gameObject);
        } 
    }
}
