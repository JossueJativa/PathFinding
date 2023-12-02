using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed; // Adjust this value to control the movement speed
    private Rigidbody rb;

    void Start()
    {
        // Get the Rigidbody component attached to the GameObject
        rb = GetComponent<Rigidbody>();

        // Make sure the Rigidbody has kinematic set to false for proper physics simulation
        rb.isKinematic = false;
    }

    void Update()
    {
        // Get input from the keyboard
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate movement direction
        Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput).normalized;

        // Move the GameObject
        MoveObject(moveDirection);
    }

    void MoveObject(Vector3 direction)
    {
        // Calculate the velocity based on the movement direction and speed
        Vector3 velocity = direction * speed;

        // Apply the velocity to the Rigidbody
        rb.velocity = new Vector3(velocity.x, rb.velocity.y, velocity.z);
    }
}
