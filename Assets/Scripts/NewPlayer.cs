using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPlayer : PhysicsObject
{
    [SerializeField] private float maxSpeed = 3;
    [SerializeField] private float jumpForce = 4.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        targetVelocity = new Vector2(Input.GetAxis("Horizontal")*maxSpeed, 0);
        if (Input.GetButtonDown("Jump") && grounded)
        {
            velocity.y = jumpForce;
        }
    }
}
