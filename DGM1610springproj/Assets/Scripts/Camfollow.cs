using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camfollow : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0,2,-4);
    void Update()
    {
       transform.position = player.transform.position + offset;
//^match cameras pos with player
    
    }
}
