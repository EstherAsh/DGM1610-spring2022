using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnmanager : MonoBehaviour
{
    public GameObject[] balloonPrefabs;
    //declaring an array
    public float startDelay = 0.5f;
    public float spawnInterval = 1.5f;



    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBalloon",startDelay,spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandomBalloon()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-5,5),10,0);
        //^generates an x y and z randomly within a range
        int balloonIndex = Random.Range(0,balloonPrefabs.Length);
        //^picks a balloon from the array list of baloon prefabs

        Instantiate(balloonPrefabs[balloonIndex],spawnPos, balloonPrefabs[balloonIndex].transform.rotation);
        //istancitate(whatwill be spawned, where, and rotation)
    }
}
