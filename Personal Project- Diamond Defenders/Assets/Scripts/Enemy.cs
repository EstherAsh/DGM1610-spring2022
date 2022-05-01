using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Enemy : MonoBehaviour
{
    [Header("Enemy Health stats")]
    public int currHP;
    public int maxHP;
    private int startHP; // will reset max HP to this on replays and resets.

    public float enemySpeed;
    public GameManager enemyRemaining;
    public int pickupChance;
    public int speed=5;
    public Vector2 destination;



    [Header("EnemyShoot")]
    public GameObject enemyProjectile;

    public int enemyDamage =2;
    public float shotDelay;
    private float angleFired;
    public Transform target;



    // Start is called before the first frame update
    void Start()
    {
        //resets health, and sets a target to move towards.
        currHP = maxHP;
        target = GameObject.FindGameObjectWithTag("Cargo").GetComponent<Transform>();
        enemyRemaining = GameObject.Find("GameManager").GetComponent<GameManager>();

        destination = new Vector2(7,transform.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        //runs the fire function every update, and moves towards destination to appear as if its flying into screen.
        Fire();
        transform.position = Vector2.MoveTowards(transform.position,destination, speed*Time.deltaTime);
    }

    void Fire()
    {
        //after a random(1-6 secs) interval, instantiates enemy projectile, 
        if(shotDelay <= 0)
        {
            Instantiate(enemyProjectile,new Vector3(transform.position.x,transform.position.y, 3),Quaternion.identity);
            shotDelay = Random.Range(1,6);
        }
        else
        {
            shotDelay -=Time.deltaTime;
            //every time minus shot delay
        }
    }

    public void TakeDamage(int damage)
    {
        //gets damage integer when called upon, and minus that agaisnt the current Health. runs a check to see if its dead.
        currHP -= damage;
        if (currHP <=0 )
        {
            Die();
        }
    }
    void Die()
    {
        //when dead, calls wavedeath (which subtracts the wave-remaining number)
        //additionally, it gnerates a random number, and if its less than 5, it spawns a pickup with the GameManagers 'SpawnPickup' function.
        //it destroys the gameobj as well.
        enemyRemaining.wavedeath();
        pickupChance = Random.Range(1,11);
        if(pickupChance<=5)
        {
            enemyRemaining.SpawnPickup();
        }
        Destroy(gameObject);
    }
}
