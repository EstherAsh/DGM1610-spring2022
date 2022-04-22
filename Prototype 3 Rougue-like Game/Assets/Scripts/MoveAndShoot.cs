using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAndShoot : MonoBehaviour
{
    public float speed, stopDistance, retreatDistance;
    private Transform target;
    private float shotDelay;
    public float startDelay;
    public GameObject projectile;
    // Start is called before the first frame update
    void Start()
    {
      target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
      //    /\ gets targets location, rotation and scale and assigns it to target variable.
      shotDelay = startDelay;
      //set shotdelay to start delay 
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(transform.position,target.position)>stopDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed *Time.deltaTime);
        }
        else if(Vector2.Distance(transform.position,target.position) < stopDistance && Vector2.Distance (transform.position, target.position) >  retreatDistance)
        {
            transform.position = this.transform.position;
        }
        else if (Vector2.Distance(transform.position, target.position)<retreatDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, -speed *Time.deltaTime);
        }
    }
}
