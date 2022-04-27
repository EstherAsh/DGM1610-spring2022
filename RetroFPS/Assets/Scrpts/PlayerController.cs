using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    private RigidBody rb;
    private Vector3 moveInput;
    private Vector2 moveInput;
    public float mouseSensitivity = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
      rb = GetComponent<RigidBody>();
      //Hie and lock curer
      Curser.visible = fasle;
      curser.lockState = CureserLockMode.Locked;  
    }

    // Update is called once per frame
    void Update()
    {
      moveInput = new Vector3(Input.GetAxis("Horizontal"),0,Input.DetAxis("Vertical"));
      Vector3 moveH = transform.right *moveInput.x;
      Vector3 moveV = transform.forward*moveInput.z;
      rb.velocity = (moveH +moveV) *moveSpeed;
      mouseInput = new vectpr3(moveInput.GetAxis("mouse X"),moveInput.GetAxis("mouse Y"))*mouseSensitivity;
      transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, -mouseInput.x,transform.rotation.eulerAngles.z);

    }
}
