using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    public int speed=9;
    public Enemy enemy;
    public int damage;
    
    // Start is called before the first frame update
    void Start()
    {
        enemy = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Enemy>();
        damage = enemy.enemyDamage;
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(Vector2.left*speed*Time.deltaTime);//moves projectile right when spawned
        if (transform.position.x <= -10)
        {
            DestroyProjectile();
        }
    }
    
    void OnTriggerEnter2D(Collider2D other)//when collision happens
    {
        if(other.CompareTag("Player"))//checks if its an enemy
        {
            other.GetComponent<PlayerController>()?.TakeDamage(damage);
            //--have EXPLOSION 
            DestroyProjectile();
        }
        else if(other.CompareTag("Sheild"))//checks if its sheild
        {
            //other.GetComponent<PlayerController>()?.TakeDamage(damage);
            //--have EXPLOSION 
            DestroyProjectile();
        }

    }
    void DestroyProjectile()
    {
        Destroy(gameObject);
    }
}
