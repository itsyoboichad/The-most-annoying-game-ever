using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPMovement : MonoBehaviour
{
    public CharacterController controller;
    public Transform groundCheck;
    public float groundDistance = .1f;
    public LayerMask groundMask;
    public float speed = 12.0f;
    public float gravity = -9.8f;
    public float jumpForce = 7.0f;

    bool isGrounded;
    Vector3 velocity;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        if (isGrounded && Input.GetButton("Jump"))
        {
            velocity.y = jumpForce;
            Debug.Log("Jumping");
            
        }

        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }
}
