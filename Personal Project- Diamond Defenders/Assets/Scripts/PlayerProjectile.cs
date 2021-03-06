using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectile : MonoBehaviour
{
    public int speed=9;
    public PlayerController player;
    public int damage;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        damage = player.playerDamage;//pulls damage from player, and uses that to put in the damage function if enemy is hit.
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(Vector2.right*speed*Time.deltaTime);//moves projectile right when spawned
        if (transform.position.x >= 10)
        {
            DestroyProjectile();
        }
    }

    void OnTriggerEnter2D(Collider2D other)//when collision happens
    {
        if(other.CompareTag("Enemy"))//checks if its an enemy
        {
            other.GetComponent<Enemy>()?.TakeDamage(damage);//runs takedamage in enemy script
            DestroyProjectile();
        }
        else if (other.CompareTag("Pickup"))//check if pickup
        {
            DestroyProjectile();
        }
    }
    void DestroyProjectile()
    {
        Destroy(gameObject);
    }
}
