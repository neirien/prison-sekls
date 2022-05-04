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
        if (Input.GetKey(KeyCode.Space))
        {
          rb.AddForce(thrust, 0, 0, ForceMode.Impulse);
        }

        
        if (isGrounded == true)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                rb.AddTorque(0, 0, thrust, ForceMode.Impulse);
            }
        }

        currentPos = transform.position;

        if (gameObject.transform.position != startPosition)
        {
            if (currentPos == lastPos)
            {
                
                //gameObject.transform.position = startPosition;
                //gameObject.transform.rotation = startRotation;
                Debug.Log("Not moving");
            }
        }
        

        lastPos = currentPos;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            Debug.Log("öldün gg");
            gameObject.transform.position = startPosition;
            gameObject.transform.rotation = startRotation;
        }
            
    }

}
