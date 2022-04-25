using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public float speed, waitTime,startWaitTime;
    public Transform startPoint;
    ////---------
    [Header("Bounds")]
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;
    ///////---------------
    
    // Start is called before the first frame update
    void Start()
    {
        waitTime = startWaitTime;
        startPoint.position = new Vector2(Random.Range(minX,maxX),Random.Range(minY,maxY));
        //start point any point within bounds 
      
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position,startPoint.position, speed*Time.deltaTime);
        if (Vector2.Distance(transform.position, startPoint.position)<0.2f)
        {
            if (waitTime <= 0)
            {
                startPoint.position = new Vector2(Random.Range(minX,maxX),Random.Range(minY,maxY));
                waitTime = Random.Range(1,5); 
            }
            else
            {
                waitTime -= Time.deltaTime;
            }
        }
        
    }
}
