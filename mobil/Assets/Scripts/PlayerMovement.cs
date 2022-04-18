using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    Rigidbody rb;
    public float thrust = 1f;   

    void Start()
    {
       rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
          rb.AddForce(thrust, 0, 0, ForceMode.Impulse);
            Debug.Log("go");
        }
      
    }
}
