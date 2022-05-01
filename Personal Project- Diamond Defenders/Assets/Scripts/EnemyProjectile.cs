using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    public int speed=9;
    public Enemy enemy;
    public int damage;
    private Transform cargo;
    private Vector2 target;
    
    void Start()
    {
        //when created get enemydamage from enemy script, assign it to this scripts 'damage'
        // Additionally, get Cargoscript from supplyship and grab its position, and assign that to var 'target'

        enemy = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Enemy>();
        damage = enemy.enemyDamage;
        cargo = GameObject.FindGameObjectWithTag("Cargo").GetComponent<Transform>();
        target = new Vector2(cargo.position.x, cargo.position.y);
    }

    void Update()
    {
        //movement- movetowards target. if it passes -10, or it has reached its destination, destroy gameOBJ.
        transform.position =Vector2.MoveTowards(transform.position, target, speed*Time.deltaTime);
        if (transform.position.x <= -10)
        {
            DestroyProjectile();
        }
        else if ( transform.position.x == target.x && transform.position.y == target.y) //has projectile reached destination
        {
            DestroyProjectile();
        }
    }
    
    void OnTriggerEnter2D(Collider2D other)//when collision happens. runs 'Takedamage' function if its the cargo ship or the player, and runs 'takehit' if its a sheild.
    {
        //after collision it gets destroyed.
        if(other.CompareTag("Player"))//checks if its an enemy
        {
            other.GetComponent<PlayerController>()?.TakeDamage(damage);
            DestroyProjectile();
        }
        else if(other.CompareTag("Shield"))//checks if its sheild
        {
            other.GetComponent<PlayerShield>()?.TakeHit(transform.position);
            DestroyProjectile();
        }
        else if(other.CompareTag("Cargo"))//checks if its the cargo ship
        {
            other.GetComponent<Cargo>()?.TakeDamage(damage);
            DestroyProjectile();
        }

    }
    public void DestroyProjectile()
    {
        Destroy(gameObject);
    }
}
