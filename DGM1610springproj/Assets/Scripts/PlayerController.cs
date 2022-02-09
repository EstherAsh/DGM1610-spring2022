using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20.0f;
    public float turnspeed = 50.0f;
    public float hInput;
    public float fInput;
    //Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
         hInput = Input.GetAxis("Horizontal");
         fInput = Input.GetAxis("Vertical");
        //Makes the player move per second
        transform.Translate(Vector3.forward * Time.deltaTime * speed * fInput );
        transform.Rotate(Vector3.up, turnspeed * Time.deltaTime * hInput);
        

    }
}
