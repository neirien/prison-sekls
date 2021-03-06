using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    Rigidbody rb;
    public float thrust = 1f;
    public float torque;
    Vector3 startPosition;
    Quaternion startRotation;
    Vector3 currentPos;
    Vector3 lastPos;
    public bool isGrounded;
    public float gravityScale = 5;
    bool jumping;
    public float jumpAmount = 20;
    bool holdTouch;
    Touch touchInfo;

    void OnCollisionStay()
    {
        isGrounded = true;
    }

    void Start()
    {
       rb = GetComponent<Rigidbody>();
       startPosition = gameObject.transform.position;
       startRotation = gameObject.transform.rotation;
    }

    void FixedUpdate()
    {
        rb.AddForce(thrust, 0, 0, ForceMode.Impulse);

        //if (Input.GetKey(KeyCode.Space))
        //{
<<<<<<< HEAD
=======

>>>>>>> 2106e5083343d2ceaa53efd6db3c72ca44001443
        //}


        rb.AddForce(Physics.gravity * (gravityScale - 1) * rb.mass);


        if (isGrounded == false)
        {

            //if (Input.GetKey(KeyCode.Z))
            if (holdTouch == true)            
            {
                rb.AddTorque(0, 0, torque, ForceMode.Impulse);
            }
        }


        //if (Input.GetKey(KeyCode.Z) && isGrounded)
            if (Input.touchCount > 0 && isGrounded)
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpAmount);
            jumping = true;
            isGrounded = false;
        }


        if (touchInfo.phase == TouchPhase.Stationary)
        {
            holdTouch = true;
        }

        if (Input.touchCount > 0)
        {
            Touch touchInfo = Input.GetTouch(0);
            
        }


            currentPos = transform.position;

        if (gameObject.transform.position != startPosition)
        {
            if (currentPos == lastPos)
            {
                
                //gameObject.transform.position = startPosition;
                //gameObject.transform.rotation = startRotation;
                //Debug.Log("Not moving");
            }
        }
        

        lastPos = currentPos;
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Platform")
        {
           Debug.Log("?ld?n gg");
           //gameObject.transform.position = startPosition;
           //gameObject.transform.rotation = startRotation;
           //FindObjectOfType<AudioManager>().Play("Death");
        }
            
                    
    }


}
