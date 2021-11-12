using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{private Rigidbody2D Rb;
    public float speed = 5f;
    Vector2 lastClickedPos;
    [SerializeField]
    bool moving;

    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            lastClickedPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            moving = true;
        }
        if (moving && (Vector2)transform.position != lastClickedPos)
        {
            float step = speed * Time.deltaTime;
            transform.position =  Vector2.MoveTowards(transform.position, lastClickedPos, step);
        }
        else
        {
            moving = false;
        }
    }

   
}
