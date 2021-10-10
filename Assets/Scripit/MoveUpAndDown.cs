using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUpAndDown : MonoBehaviour
{
    
    Rigidbody2D Rb2D;
    public float speed = 5;
    Vector2 MoveDirection;
    void Start()
    {
        Rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        ProcessInputs();
    }

    void FixedUpdate()
    {
        Move();
    }

    void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        MoveDirection = new Vector2(moveX, moveY).normalized;
    }

    void Move()
    {
        Rb2D.velocity = new Vector2(MoveDirection.x * speed, MoveDirection.y * speed);
    }
}
