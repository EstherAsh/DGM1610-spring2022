using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Health")]
    public int currHP; //current health points
    public int maxHP; //HP at beginning/ HP when healed. cannot go above this HP value.
    //public HPBar hpBar;

    [Header ("Player Movement")]
    public float moveSpeed = 5.0f;//speed of player movement, gets multiplied by movement actions.
    private Rigidbody2D rb; //store refrenced 2d Rigidbody
    Vector2 movement;//store player XY position movement
    Vector2 direction;
    
    [Header("Combat")]
    public GameObject projectile;
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
    }

    // Update is called once per frame
    void Update()
    {
        movement.y = Input.GetAxis("Vertical");//Input for up&down movement

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
    void FixedUpdate() //set number of calls per frame
    {
        //apply phys and move char
        rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);
        //time.delta time uses seconds rather than frames, safe for all computers and graphics


    }
    void Fire()
    {
        Debug.Log("shots fired");
    }
    public void TakeDamage()
    {

    }
    void Heal()
    {
        
    }
    void Die()
    {

    }
}
