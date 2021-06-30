using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController playercontroller;
    public Transform checkspherepos;

    public float walkspeed = 5f, runspeed = 10f, g = 2f, checkradius, jumpheight = 5f;
    private float movespeed;
    Vector3 velocity;
    public LayerMask ground;
    bool onground;
    public bool iswalking, check1 = false, check2 = false;
    public GameObject Works, Light;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            check1 = !check1;
            Works.SetActive(check1);
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            check2 = !check2;
            Light.SetActive(check2);
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            iswalking = false;
            movespeed = runspeed;
        }
        else
        {
            iswalking = true;
            movespeed = walkspeed;
        }

        onground = Physics.CheckSphere(checkspherepos.position, checkradius, ground);

        if(onground)
        {
            velocity.y = -1f;
        }
        else
        {
            velocity.y -= g * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.Space) && onground == true)
        {
            velocity.y = jumpheight;
        }

        playercontroller.Move(velocity);

        float x = Input.GetAxis("Horizontal") * movespeed * Time.deltaTime;
        float y = Input.GetAxis("Vertical") * movespeed * Time.deltaTime;

        playercontroller.Move(transform.forward * y);
        playercontroller.Move(transform.right * x);
    }
}
