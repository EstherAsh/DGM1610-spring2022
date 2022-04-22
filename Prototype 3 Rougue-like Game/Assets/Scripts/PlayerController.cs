using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    public float movespeed = 5.0f; // Speed of player movement
    private Rigidbody2D rb; //store refrenced 2d Rigidbody
    Vector2 movement; // store player XY position movement





    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        // ^ is getting the rigidbody
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal"); //Input for LR movement
        movement.y = Input.GetAxis("Vertical"); //Input for LR movement
        //reminder: pysics stuffs should be under fixed update, while update is fine for inputs

    }
    void FixedUpdate() //set number of calls per frame
    {
        //apply phys and move char
        rb.MovePosition(rb.position + movement* movespeed*Time.deltaTime);
        //time.delta time uses seconds rather than frames, safe for all computers and graphics

    }
}
