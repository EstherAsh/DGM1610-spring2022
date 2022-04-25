using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed;
    private Transform player;
    private Vector2 target;
    //ooo so assign target as last known position, iw players pos when fired. static.

    // Start is called before the first frame update
    void Start()
    {
        //      capital G is game obj class
       player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
       target = new Vector2(player.position.x, player.position.y);
       //basically getting player pos when its made, and then assigns that to ''target'' 
    }

    // Update is called once per frame
    void Update()
    {
        transform.position =Vector2.MoveTowards(transform.position, target, speed*Time.deltaTime);
        //^this obj position         ^moving towards   ^start           ^end     ^how fast
        if ( transform.position.x == target.x && transform.position.y == target.y)//has projectile reached destination
        {
            DestroyProjectile();
        }
    }
    void OnTriggerEnter2D(Collider2D other)//WHEN IT COLLIDES
    {
       if(other.CompareTag("Player"))//check if player
       {
           DestroyProjectile();
       } 
    }





    void DestroyProjectile()
    {
        Destroy(gameObject);//lowercase g is refering to a variable that is storing the game obj.
        //make it its own thing so later if we want particles/ sound/ anything else to happen when its destroyed.
    }
}
