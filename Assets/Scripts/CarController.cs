using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public float speed = 15000f;
    public float rotationSpeed = 1500f;

    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float moveInput = Input.GetAxis("Vertical");
        float rotateInput = Input.GetAxis("Horizontal");

        // Move the car forward/backward
        Vector3 movement = transform.forward * moveInput * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + movement);

        // Rotate the car left/right
        float rotation = rotateInput * rotationSpeed * Time.fixedDeltaTime;
        Quaternion rotationQuaternion = Quaternion.Euler(0f, rotation, 0f);
        rb.MoveRotation(rb.rotation * rotationQuaternion);
    }
}
