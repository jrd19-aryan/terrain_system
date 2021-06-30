using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class droneflight : MonoBehaviour
{
    public CharacterController playercontroller;
    private float MoveSpeed;
    public float flightspeed = 5f;
    public Vector3 vel;
    public GameObject Lights;
    public bool check = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            check = !check;
            Lights.SetActive(check);
        }

        if (Input.GetKey(KeyCode.U))
        {
            vel.y = flightspeed;
        }
        else if (Input.GetKey(KeyCode.J))
        {
            vel.y = -1f * flightspeed;
        }
        else
        {
            vel.y = 0f;
        }

        playercontroller.Move(vel);
    }
}
