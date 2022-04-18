using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableJump : MonoBehaviour
{
    Rigidbody rb;
    public float buttonTime = 0.3f;
    public float jumpAmount = 20;
    float jumpTime;
    bool jumping;
    public float gravityScale = 5;
    public bool isGrounded;

    void OnCollisionStay()
    {
        isGrounded = true;
    }

    private void FixedUpdate()
    {
        rb.AddForce(Physics.gravity * (gravityScale - 1) * rb.mass);
    }

    private void Start()
    {
       rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z) && isGrounded)
        {
            jumping = true;
            jumpTime = 0;
            isGrounded = false;
        }
        if (jumping)
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpAmount);
            jumpTime += Time.deltaTime;
            isGrounded = false;
        }
        if (Input.GetKeyUp(KeyCode.Z) | jumpTime > buttonTime)
        {
            jumping = false;
        }
    }
}
