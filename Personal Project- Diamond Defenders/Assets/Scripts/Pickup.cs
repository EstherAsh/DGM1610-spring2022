using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public enum PickupType{heal,attack,ShieldCoolReset};
    public PickupType pickupChoice= PickupType.attack;
    private PlayerController player; 
    public GameObject damageBooster;
    int healAmt = 5;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down*3*Time.deltaTime);//moves pickup down the screen.
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        //when hit checks its pickup choice, and then either heals, boosts players attack or resets shield cooldown.
        if (other.CompareTag("Projectile"))
        {
            switch(pickupChoice)
            {
                case PickupType.heal:
                    Heal(healAmt);
                    break;
                case PickupType.attack:
                    Attack();
                    break;
                case PickupType.ShieldCoolReset:
                    Shield();
                    break;
            }
        }
    }
    void Heal(int healAmt)//runs heal function in the playercontroller
    {
        player.Heal(healAmt);
        Destroy(gameObject);
    }
    void Attack()//creates damageboost empty game obj(which boosts the attack)
    {
        Instantiate(damageBooster,new Vector3(transform.position.x,transform.position.y, 2),Quaternion.identity);
        Destroy(gameObject);
    }
    void Shield()//gets players sheild cooldown and sets it to 0.
    {
        player.shieldCooldown = 0;
        Destroy(gameObject);
    }
    public void ChangeHeal()//change pickup choice to heal.
    {
        pickupChoice = PickupType.heal;
    }
    public void ChangeAttack()//change pickup choice to attack.
    {
        pickupChoice = PickupType.attack;
    }
    public void ChangeShield()//change pickup choice to sheild reset.
    {
        pickupChoice = PickupType.ShieldCoolReset;
    }
}
