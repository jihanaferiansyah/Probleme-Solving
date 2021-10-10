using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D Rb2D;
    public float speed = 500;

    void Start()
    {
        Rb2D = GetComponent<Rigidbody2D>();
        Rb2D.AddForce
            (new Vector2(20 * Time.deltaTime * speed, 20 * Time.deltaTime * speed));
    }
}