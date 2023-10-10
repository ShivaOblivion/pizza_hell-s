using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class test : MonoBehaviour
{
    public float movesSpeed;
    public float jumpForce;
    public Rigidbody2D rb;

    private float horisontalMovemant;
    private Vector3 velocity= Vector2.zero;

    private void Awake()
    {
       
    }

  


    void Update()
    {
    horisontalMovemant = (horisontalMovemant* movesSpeed * Time.deltaTime);

    }

    private void FixedUpdate()
    {
        Moveplayer(horisontalMovemant);
    }

    void Moveplayer(float _velociter)
    {
        Vector3 tagetVelocity = new Vector2(_velociter, rb.velocity.y);
        rb.velocity = Vector3.SmoothDamp(rb.velocity,tagetVelocity,ref velocity,.5f);
    }
    private void OnQD(InputAction.CallbackContext valus)
    {
         horisontalMovemant= valus.ReadValue<float>();
    }
    
}
