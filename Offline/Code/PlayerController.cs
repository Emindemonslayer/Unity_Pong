using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerController : MonoBehaviour
{
    Vector3 velocity,velocity2;
    public bool isPlayer1;
    public Rigidbody2D rg;
    public float speed;
    public float v,v2;

    InputValue value;
   

    void Start()
    {
     
    }
    void Update()
    {
        if (isPlayer1)
        {
            rg.velocity = Vector2.up * v * speed;
        }
        else
        {
            rg.velocity = Vector2.up * v2 * speed;
        }
    }
    public void OnPlayer1(InputValue movement)
    {
        Vector2 input = movement.Get<Vector2>();
        velocity.z = input.y;
        v = velocity.z;
    }
    void OnPlayer2(InputValue movement)
    {
        Vector2 input = movement.Get<Vector2>();
        velocity2.z = input.y;
        v2 = velocity2.z;
    }
}
