using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header ("Player Health")]
    public int curHP;//current health points
    public int maxHP;//full HP, maximum Health points the player can have
    public HPBar hpBar;

    /////---------------
    
    [Header ("Player Movement")]
    public float movespeed = 5.0f; // Speed of player movement
    private Rigidbody2D rb; //store refrenced 2d Rigidbody
    Vector2 movement; // store player XY position movement
    Vector2 direction;
    ///////-------------
    [Header ("Player Combat")]
    public int Damage;
    public float attackRange;
    public float attackRate;
    private float lastAttackTime;
    public LayerMask enemyLayer;
    ///----
    [Header("Inventory")]
    public int key;
    public int coins;
    public int gems;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        // ^ is getting the rigidbody
        curHP = maxHP;
        hpBar.SetHealth(maxHP);//sets health bar to full
        
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal"); //Input for LR movement
        movement.y = Input.GetAxis("Vertical"); //Input for LR movement
        //reminder: pysics stuffs should be under fixed update, while update is fine for inputs
        
        if(Input.GetKeyDown(KeyCode.X))
        {
            if (Time.time - lastAttackTime >= attackRate)
            {
                Attack();
            }
        }
    }
    void FixedUpdate() //set number of calls per frame
    {
        //apply phys and move char
        rb.MovePosition(rb.position + movement* movespeed*Time.deltaTime);
        //time.delta time uses seconds rather than frames, safe for all computers and graphics

        UpdateDirection();
    }
    void UpdateDirection()
    {
        Vector2 vel = new Vector2(movement.x,movement.y);
        if (vel.magnitude != 0)
        {
            direction = vel;
        }
        rb.velocity = vel * movespeed;
    }
    void Attack()
    {
        lastAttackTime = Time.time;

        RaycastHit2D hit = Physics2D.Raycast(transform.position,direction,attackRange, enemyLayer);
        //raycast using enemy layer
        if(hit.collider != null)//if hit variable doesnt not hit something 
        {
            hit.collider.GetComponent<Enemy>()?.TakeDamage(Damage);
            //runs  the ''take damage script'' in Enemy that was hit
            //In hit collider, get the component enemy and run take damage.
        }
    }

    public void TakeDamage(int damage)
    {
        curHP -= damage;
        hpBar.SetHealth(curHP);//updare health bar using current HP.
        if (curHP <0 )
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Player has died");
    }

}
