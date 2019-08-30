using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Source: Jimmy Vegas- How To Make an FPS

public class PistolDamage : MonoBehaviour
{
    public int damage = 50;
    public int range = 15;
    public Camera fpsCam;


    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            RaycastHit hit;
            //raycasts sends out a hit to see if object is within range of player (forward direction)
            if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
            {
                Debug.Log(hit.transform.name);

                //if zombie is within range then inflict damage onto its health;
                Zombie enemy = hit.transform.GetComponent<Zombie>();
                if (enemy != null)
                {
                    enemy.DamageInflicted(damage);
                }

                //if there's no ammo loaded, set damage to 0
                if(Ammo.LoadedAmmo <= 0)
                {
                    damage = 0;
                    //enemy.DamageInflicted(damage);
                }
                else
                //if there is ammmo remaining, set damage to 50
                {
                    damage = 50;
                }
            }
        }
    }
}



