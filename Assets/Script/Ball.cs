using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody rb;
    public static int kecepatan = 10;
    private float xInput;
    private float zInput;

    public AudioSource collectSound;
    public Transform cam;

   
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        ProcessInputs();
    }
    private void FixedUpdate()
    {
        Move();
    }
    private void ProcessInputs()
    {
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");
    }
    private void Move()
    {
        rb.AddForce(new Vector3(xInput, 0F, zInput) * kecepatan);
    }
    private void OnCollisionEnter(Collision kena)
    {
        if (kena.collider.CompareTag("enemy"))
        {
            scoring.score -= 10;
            collectSound.Play();
            Destroy(kena.collider.gameObject);
        }
    }
}
