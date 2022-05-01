using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class PlayerController : MonoBehaviour
{
    [Header("Health")]
    public int currHP;
    public int maxHP;
    private int startHP =20;
    //public HPBar hpBar;
    public Cargo cargoShip;

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
    public float shieldCooldown;
    public GameObject shield;
    public bool shieldExist;
    public int playerDamage;
    public float shotDelay;
    public LayerMask enemyLayer;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        maxHP = startHP;
        currHP = maxHP;
        cargoShip = GameObject.Find("SupplyShip").GetComponent<Cargo>();
        //hpBar.SetHealth(maxHP);//sets hp bar to full.
        shotDelay = 1;
        moveSpeed = startSpeed;
        shieldCooldown = 15.0f;
    }

    // Update is called once per frame
    void Update()
    {
        movement.y = Input.GetAxis("Vertical");//Input for up&down movement

        Fire();
        Shield();

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
    void Fire()//if shot delay is zero and left shift is pressed, instantiate a player projectile, and reset shot delay.
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
    void Shield()//When you press space and the sheildcooldown is 0, a sheild spawns
    {
        if(shieldCooldown <=0)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                shieldExist = true;
                Instantiate(shield,new Vector3(transform.position.x+1.0f,transform.position.y, -1),Quaternion.identity);
                shieldCooldown = 15.0f;
            }
        }
        else if (shieldExist == false )
        {

            shieldCooldown -= Time.deltaTime;
        }

    }

    public void ShieldBreak()//when shield break, set exist to false
    {
        shieldExist = false;
    }

    public void TakeDamage(int enemyDamage)//subtracts enemy damage(from enemy projectile) from current health, and checks if dead.
    {
        currHP -= enemyDamage;
        if (currHP <0 )
        {
            Die();
        }

    }
    public void Heal(int healAmt)//heals the player IF the players health is lower than the cargo ships. if not, heals the cargoship.
    {
        if(currHP<= cargoShip.currHP)
        {
            if(currHP+healAmt >=maxHP)
            {
                currHP=maxHP;
            }
            else
            {
                currHP+=healAmt;
            }
        }
        else if (cargoShip.currHP< currHP)
        {
            cargoShip.Heal(healAmt);
        }
        
    }

    void Die()
    {
        //Debug.Log("You died!");
        //OVERLAY BUTTONS: TRY AGAIN AND MAIN MENU
        //TRY AGAIN SIMPLY RUNS A FUNTION ON GAMEMANAGER CALLED RESET-- (sets all waves killed to 0; resets health and positions of all characters, and runs 'start' funtions of the player again.)
        //main menu sends you to the main menu.

    }
}
