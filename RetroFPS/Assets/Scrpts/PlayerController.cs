using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  public static PlayerController instance;
  public float moveSpeed;
  private Rigidbody rb;
  private Vector3 moveInput;
  private Vector2 mouseInput;
  public float mouseSensitivity = 1.0f;

  public Camera viewCam;
  public GameObject bulletImpact;
  public int currentAmmo;


  private void Awake()
  {
    instance = this;
  }
  // Start is called before the first frame update
  void Start()
  {
    rb = GetComponent<Rigidbody>();
    //Hie and lock curer
    Cursor.visible = false;
    Cursor.lockState = CursorLockMode.Locked;  
  }

  // Update is called once per frame
  void Update()
  {
    moveInput = new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));//getting Input
    Vector3 moveH = transform.right *moveInput.x;
    Vector3 moveV = transform.forward*moveInput.z;//nlend/diagonal movement
    rb.velocity = (moveH +moveV) *moveSpeed;

    mouseInput = new Vector2(Input.GetAxis("Mouse X"),Input.GetAxis("Mouse Y")) * mouseSensitivity;
    transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y -mouseInput.x,transform.rotation.eulerAngles.z);//calculating rotation on x,y and z
    if(Input.GetMouseButtonDown(0))
    {
      if(currentAmmo>0)
      {
        Ray ray = viewCam.ViewportPointToRay(new Vector3(0.5f,0.5f,0.0f));
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit))
        {
          Debug.Log("Im looking at "+ hit.transform.name+".");
          Instantiate(bulletImpact, hit.point,transform.rotation);
        }
        else
        {
          Debug.Log("Im not looking at anything");
        }
        currentAmmo--;
  
      }
    }
    
  }
}
