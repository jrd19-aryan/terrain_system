using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float sensitivity = 100f;
    public Transform player;
    float rot;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;    
    }

    void Update()
    {
        float x = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float y = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        rot -= y;
        rot = Mathf.Clamp(rot, -90f, 75f);
        transform.localRotation = Quaternion.Euler(rot, 0, 0);
        player.Rotate(player.up * x);
    }
}
