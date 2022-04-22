using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public float speed; //speed
    public float stopDistance; // 
    private Transform target; // 
    // Start is called before the first frame update
    void Start()
    {
       target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
       //finds obj with the tag player, and get the position rotation and scale, and puts it into the ''target'' variable

    }

    // Update is called once per frame
    void Update()
    {
        //if enemys pos             vvvv       and  player vvvvv is greater than 5
        if(Vector2.Distance(transform.position, target.position) > stopDistance) 
        {
            transform.position =Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            //change enemys pos /\ and move towards the target

        }
    }
}
