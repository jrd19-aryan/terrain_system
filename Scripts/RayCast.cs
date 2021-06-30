using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    public Camera PlayerCamera;
    public float firerate = 10f, damage = 20f;
    float delay;

    //Ammo
    [Header("Ammo Management")]
    public int ammocount = 25, ammostock = 500, maxammo = 25;
    public float reloadtime;
    public Animator anim;

    void Update()
    {
        if ((ammostock + ammocount)  > 0)
        {
            if (Input.GetKeyDown(KeyCode.R) && ammocount < 25)
            {
                anim.SetBool("reload", true);
                return;
            }

            if (ammocount <= 0)
            {
                anim.SetBool("reload", true);
                return;
            }

            if (Input.GetButton("Fire1") && Time.time >= delay)
            {
                delay = Time.time + 1f / firerate;
                RayCastShoot();
            }
        }
    }

    void RayCastShoot()
    {
        ammocount--;

        RaycastHit hit;
        if (Physics.Raycast(PlayerCamera.transform.position, PlayerCamera.transform.forward, out hit))
        {
            if(hit.transform.tag == "Enemy")
            {       
                Debug.Log(hit.transform.name);
                Health enemy = hit.transform.GetComponent<Health>();
                enemy.Damage(damage);
            }
        }
    }

    public void Reload()
    {
        if((ammostock + ammocount) >= maxammo)
        {
            ammostock = (ammostock + ammocount) - maxammo;
            ammocount = maxammo;
        }
        else
        {
            ammocount += ammostock;
            ammostock = 0;
        }
        
        anim.SetBool("reload", false);
    }
}
