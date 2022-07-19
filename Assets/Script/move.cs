using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float moveSpeed;
    [SerializeField] float jumpPower;
    float hInput;
    float vInput;
    bool jumpInput;

     void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
   
    void Update()
    {
        hInput = Input.GetAxis("Horizontal") * moveSpeed;
        vInput = Input.GetAxis("Vertical") * moveSpeed;
        jumpInput = Input.GetKeyDown(KeyCode.Space);
    }
    private void FixedUpdate()
    {
        Move();

        if (jumpInput)
        {
            jump();
            jumpInput = false;
        }
    }
    void Move()
    {
        rb.AddForce(hInput * Time.fixedDeltaTime, 0f, vInput * Time.fixedDeltaTime);

    }
    void jump()
    {
        rb.AddForce(Vector3.up * jumpPower * Time.fixedDeltaTime, ForceMode.Impulse);
    }
}
