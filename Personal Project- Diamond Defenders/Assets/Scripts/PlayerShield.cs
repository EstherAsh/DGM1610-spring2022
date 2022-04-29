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
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        shieldDurability = 5;
        player.shieldExist = true;
    }

    // Update is called once per frame
    void Update()
    {
        
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
        else
        {
            Instantiate(projectile,new Vector3(whereHit.x,whereHit.y, 2),Quaternion.identity);
            shieldDurability --;//takes one off sheild durability
        }

    }
}
