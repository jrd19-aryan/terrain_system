using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimManager : MonoBehaviour
{
    public Animator anim;
    public PlayerMovement player;
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        if(x == 0 && y == 0)
        {
            anim.SetBool("breathe", true);
            anim.SetBool("walk", false);
            anim.SetBool("sprint", false);
        }
        else
        {
            if(player.iswalking == false)
            {
                anim.SetBool("breathe", false);
                anim.SetBool("walk", false);
                anim.SetBool("sprint", true);
            }
            else if(player.iswalking == true)
            {
                anim.SetBool("breathe", false);
                anim.SetBool("walk", true);
                anim.SetBool("sprint", false);
            }
        }
    }
}
