using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Attach this script to Jamie nya :3 this will allow him to move around
public class PlayerControls : MonoBehaviour
{
    public Transform camera;
    public CharacterController controller;
    public float speed = 3f;
    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        camera = Camera.main.GetComponent<Transform>();
    }

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(horizontal, 0, vertical).normalized;

        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + camera.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);


            Vector3 moveDirection = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.Move(moveDirection.normalized * speed * Time.deltaTime);
        }
    }

    // For CPU time indepent physics calculations
    void FixedUpdate()
    {

    }
}
