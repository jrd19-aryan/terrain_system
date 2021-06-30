using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playertoggle : MonoBehaviour
{
    public GameObject player1, player2;
    bool toggle = true;
    void Start()
    {
        player1.SetActive(true);
        player2.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Toggle();
            toggle = !toggle;
        }
    }

    void Toggle()
    {
        player1.SetActive(!toggle);
        player2.SetActive(toggle);
    }
}
