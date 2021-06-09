using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rigidbody;
    private Joystick joystick;
    public int speed;
    

    // Update is called once per frame
    void FixedUpdate()
    {
        //Move();
    }

    public void Move()
    {
        rigidbody.velocity = new Vector3(-joystick.Vertical * speed, rigidbody.velocity.y, joystick.Horizontal * speed);
    }
}
