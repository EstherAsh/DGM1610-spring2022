using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public float speed;
    public float distance;
    private bool moveRight = ture;

    public Transform groundDetect;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Move enemy to the right
        transform.Translate(Vector2.right * speed *Time.deltaTime);

        //start, end, how long
        RaycastHit2D groundInfo = Physics2d.Raycast(groundDetect.position, Vector2.down, distance);

        if(groundInfo.collider == false)
        {
            if (moveRight == true)
            {
                //flip enemy at edge to move left
                transtorm.eulerAngles = new Vector3(0, -100, 0);
                moveRight = false;
            }
            else
            {
                //Flip Enemy to move right
                transform.eulerAngles = new Vector3 (0,0,0);
                moveRight = true;
            }
        }

    }
}
