using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public float speed;
    public float distance;
    private bool moveright =true;
    public Transform groundDetection;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move enemy right
        transform.Translate(Vector2.right *speed*Time.deltaTime);
        
        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position,Vector2.down, distance);
        //setting ground info variable, looking at floor, detecting floor until edge

        if(groundInfo.collider ==false)
        {
            if (moveright == true)
            {
                //flip enemy at edge to move left
                transform.eulerAngles = new Vector3(0,-180,0);
                moveright =false;
            }
            else
            {
                //flip enemy at edge to move right
                transform.eulerAngles = new Vector3(0,0,0);
                moveright=true;
            }
        }
    }
}
