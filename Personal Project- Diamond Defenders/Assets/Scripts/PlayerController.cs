using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class PlayerController : MonoBehaviour
{
    [Header("Health")]
    public int currHP; //current health points
    public int maxHP; //HP at beginning/ HP when healed. cannot go above this HP value.
    //public HPBar hpBar;
    

    [Header ("Player Movement")]
    public float startSpeed = 5.0f;
    public float moveSpeed = 5.0f;//speed of player movement, gets multiplied by movement actions.
    public float boostSpeed;
    public int boostTime;
    private Rigidbody2D rb; //store refrenced 2d Rigidbody
    Vector2 movement;//store player XY position movement
    Vector2 direction;
    public float upperBound;
    public float lowerBound;
    
    [Header("Combat")]
    public GameObject projectile;
    public float sheildCooldown;
    public GameObject sheild;
    public int playerDamage;
    public float shotDelay;
    public LayerMask enemyLayer;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currHP = maxHP;
        //hpBar.SetHealth(maxHP);//sets hp bar to full.
        shotDelay = 1;
        moveSpeed = startSpeed;
        sheildCooldown = 15.0f;
    }

    // Update is called once per frame
    void Update()
    {
        movement.y = Input.GetAxis("Vertical");//Input for up&down movement

        Fire();
        Sheild();

        //Boundary check
        if(transform.position.y >=upperBound)
        {
            transform.position =new Vector2(transform.position.x,upperBound);
        }
        if(transform.position.y <=lowerBound)
        {
            transform.position =new Vector2(transform.position.x,lowerBound);
        }
    }
    void FixedUpdate() //set number of calls per frame
    {
        //apply phys and move char
        rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);
        
        



    }
    void Fire()
    {
        if(shotDelay <=0)
        {
            if(Input.GetKeyDown(KeyCode.LeftShift))
            {
                Instantiate(projectile,new Vector3(transform.position.x,transform.position.y, 2),Quaternion.identity);
                shotDelay = 1;
            }
        }
        else
        {
            shotDelay -= Time.deltaTime;
        }
    }
    void Sheild()
    {
        if(sheildCooldown <=0)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(sheild,new Vector3(transform.position.x+1.0f,transform.position.y, -1),Quaternion.identity);
                sheildCooldown = 15.0f;
            }
        }
        else
        {
            sheildCooldown -= Time.deltaTime;
        }

    }
    public void TakeDamage(int enemyDamage)
    {
        currHP -= enemyDamage;
        //hpBar.SetHealth(currHP);//update health bar using current HP.
        if (currHP <0 )
        {
            Die();
        }

    }
    void Heal(int healAmt)
    {
        if(currHP+healAmt >=maxHP)
        {
            currHP=maxHP;
            //turn green for a split second when pickup.
        }
        else
        {
            currHP+=healAmt;
            //turn green for a split second when pickup.
        }
        
    }
    void SpeedBoost()
    {
        //do this later
        
        
    }
    void Die()
    {
        Debug.Log("You died!");
        //OVERLAY BUTTONS: TRY AGAIN AND MAIN MENU
        //TRY AGAIN SIMPLY RUNS A FUNTION ON GAMEMANAGER CALLED RESET-- (sets all waves killed to 0; resets health and positions of all characters, and runs 'start' funtions of the player again.)
        //main menu sends you to the main menu.

    }
}
