using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShield : MonoBehaviour
{
    public int shieldDurability;
    public bool shieldExist;
    public PlayerController player;
    public Vector3 whereHit;
    public PlayerProjectile projectile;

    void Start()
    {
        //when spawned, reset sheild durability and make sheildexist true.
        //sheild exist runs as a precaution to prohibit the player from spawning a wall of sheilds.
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        shieldDurability = 5;
        player.shieldExist = true;
    }

    public void TakeHit(Vector3 whereHit)
    {
        Debug.Log("log hit on shield");
        if(shieldDurability<=0)
        {
            shieldDurability = 5;//resets sheild durability
            player.ShieldBreak();//runs funtion in Player controller that sets sheild exist to false
            //particle effect
            Destroy(gameObject);

        }
        else//spawns a player porjectile to appear as if the sheild 'reflects' the enemy projectile.
        {
            Instantiate(projectile,new Vector3(whereHit.x,whereHit.y, 2),Quaternion.identity);
            shieldDurability --;//takes one off sheild durability
        }

    }
}
