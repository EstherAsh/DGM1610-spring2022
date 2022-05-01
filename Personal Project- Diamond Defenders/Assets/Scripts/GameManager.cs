using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using TextMeshProUi;

public class GameManager : MonoBehaviour
{
    [Header("Wave Details")]
    public GameObject wave1;
    public GameObject wave2;
    public GameObject wave3;
    public GameObject wave4;
    public Enemy enemy;
    public int waveRemaining;
    public float waveChance;
    public int statIncrease=1;

    [Header("Pickup")]
    public GameObject pickup;
    public Pickup pickupScript;
    public float pickupChance;
    public float pickupMinX;
    public float pickupMaxX;
    public Vector2 spawner;

    void Start()
    {
        //Begins game, and immediatly spawns in the first wave   
        waveRemaining=0;
    }

    void Update()
    {
        //if all eneimies in a wave are defeated(count is 0), spawn a new wave.
        if(waveRemaining <=0)
        {
            NewWave();
        }
    }
    void NewWave()
    {
        //clears empty gameOBj containing the waves
        //generates a number between 1 and fourty, and uses that to choose which wave will spawn.
        //resets waveRemaining according to the wave and how many enemies
        //then increases 'stat increase' the incriment that gets added onto the enemies stats, like health and damage.
        Clear();
        waveChance = Random.Range(1,40);
        if(waveChance<10)
        {
            Instantiate(wave1,new Vector3(10,0, -2), Quaternion.identity);
            waveRemaining =3;

            enemy = GameObject.Find("wave1small1").GetComponent<Enemy>();
            enemy.enemyDamage+=statIncrease;
            enemy.maxHP+=statIncrease;
            enemy.currHP = enemy.maxHP;

            enemy = GameObject.Find("wave1small2").GetComponent<Enemy>();
            enemy.enemyDamage+=statIncrease;
            enemy.maxHP+=statIncrease;
            enemy.currHP = enemy.maxHP;

            enemy = GameObject.Find("wave1small3").GetComponent<Enemy>();
            enemy.enemyDamage+=statIncrease;
            enemy.maxHP+=statIncrease;
            enemy.currHP = enemy.maxHP;
        }
        else if(waveChance>10 && waveChance<20)
        {
            Instantiate(wave2,new Vector3(10,0, -2), Quaternion.identity);
            waveRemaining = 2;

            enemy = GameObject.Find("wave2big1").GetComponent<Enemy>();
            enemy.enemyDamage+=statIncrease;
            enemy.maxHP+=statIncrease;
            enemy.currHP = enemy.maxHP;

            enemy = GameObject.Find("wave2big2").GetComponent<Enemy>();
            enemy.enemyDamage+=statIncrease;
            enemy.maxHP+=statIncrease;
            enemy.currHP = enemy.maxHP;

        }
        else if (waveChance>20 &&waveChance<30)
        {
            Instantiate(wave3,new Vector3(10,0, -2), Quaternion.identity);
            waveRemaining = 3;  

            enemy = GameObject.Find("wave3small1").GetComponent<Enemy>();
            enemy.enemyDamage+=statIncrease;
            enemy.maxHP+=statIncrease;
            enemy.currHP = enemy.maxHP;

            enemy = GameObject.Find("wave3small2").GetComponent<Enemy>();
            enemy.enemyDamage+=statIncrease;
            enemy.maxHP+=statIncrease;
            enemy.currHP = enemy.maxHP;

            enemy = GameObject.Find("wave3big1").GetComponent<Enemy>();
            enemy.enemyDamage+=statIncrease;
            enemy.maxHP+=statIncrease;
            enemy.currHP = enemy.maxHP;           
        }
        else
        {
            Instantiate(wave4,new Vector3(10,0, -2), Quaternion.identity);
            waveRemaining = 2;

            enemy = GameObject.Find("wave4small1").GetComponent<Enemy>();
            enemy.enemyDamage+=statIncrease;
            enemy.maxHP+=statIncrease;
            enemy.currHP = enemy.maxHP;

            enemy = GameObject.Find("wave4small2").GetComponent<Enemy>();
            enemy.enemyDamage+=statIncrease;
            enemy.maxHP+=statIncrease;
            enemy.currHP = enemy.maxHP;
        }
        statIncrease +=1;
    }
    void Clear()
    {
        //clears the empty game obj that held the wave.
        Destroy(GameObject.FindGameObjectWithTag("wavetype"));
    }
    public void wavedeath()
    {
        //when an enemy dies, they call to this function
        //minus one on waveremaining
        waveRemaining -= 1;
    }
    public void SpawnPickup()
    {
        //on enemys death there is a ~50% chance they will call to this function, spawning a powerup.
        //this also changes the pickup type randomly to be heals, an attack boost, or a reset of the shield cooldown.
        Instantiate(pickup,new Vector3(Random.Range(pickupMinX,pickupMaxX),6, 2), Quaternion.identity);
        pickupChance = Random.Range(1,30);
        if(pickupChance <10)
        {
            pickupScript = pickup.GetComponent<Pickup>();
            pickupScript.ChangeHeal();
        }
        else if(pickupChance >10&&pickupChance<20)
        {
            pickupScript = pickup.GetComponent<Pickup>();
            pickupScript.ChangeAttack();
        }
        else
        {
            pickupScript = pickup.GetComponent<Pickup>();
            pickupScript.ChangeShield();
        }

    }
    void AddPoint(int pointsToAdd)
    {
        //call to this when a player dies and when you reflect a bullet with your shield.
        // this updates the 'score' variable
        //which has a UI attached to it.
    }
    void LevelUp()
    {
        //when it has reached certain points, the player will get certain upgrades(more health and stronger bullets.)
    }
    void RESET()
    {
        //move everything to starting point
        //reset all changing variable
        //have player and escort redo its 'start' function
    }
}
