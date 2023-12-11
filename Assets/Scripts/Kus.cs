using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kus : MonoBehaviour
{
    public bool isDead;
    public float velocity = 1f;
    public Rigidbody2D Rb2D;


    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Rb2D.velocity = Vector2.up * velocity;
        }

    }
}
