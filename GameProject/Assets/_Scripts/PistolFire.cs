using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Source: Jimmy Vegas- How To Make an FPS

public class PistolFire : MonoBehaviour
{
    public AudioSource shoot;
    public Animation anim;
    public AudioSource empty;

    // Start is called before the first frame update
    void Start()
    {
        
        anim = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {

        //checks if fire button is pressed down
        if (Input.GetButtonDown("Fire1")) 
        {
            //if there is ammo remaining in the gun
            if (Ammo.LoadedAmmo >= 1)
            {
                //play the shoot sound and animation
                shoot.Play();
                anim.Play("GunShot");
                //take away 1 from loaded ammo after each fire
                Ammo.LoadedAmmo -= 1;

            }

            //if there's no ammo play empty sound
            else if (Ammo.LoadedAmmo >= 0)
            {
                empty.Play();
            }
        }



    }
}
