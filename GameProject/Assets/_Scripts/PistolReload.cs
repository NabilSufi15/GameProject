using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Source: Jimmy Vegas- How To Make an FPS

public class PistolReload : MonoBehaviour
{

    public AudioSource ReloadSound;
    public int Clip;
    public int ReserveAmmo;
    public int ReloadAvailable;
    public PistolFire PistolComponent;
    public Animation anim;
    public AudioSource death;

    void Start()
    {
        PistolComponent = GetComponent<PistolFire>();
        anim = GetComponent<Animation>();
    }

    void Update()
    {
        //constantly updates loaded and current ammo
        Clip = Ammo.LoadedAmmo;
        ReserveAmmo = Ammo.CurrentAmmo;

        // if there's no ammo left, there's no reload available
        if (ReserveAmmo == 0)
        {
            ReloadAvailable = 0;
        }

        //if there's ammo left, reload the gun with amount available within the clip
        else
        {
            
            ReloadAvailable = 10 - Clip;
        }

        if (Input.GetButtonDown("Reload"))
        {
            //if there's more than 1 bullet
            if (ReloadAvailable >= 1)
            {
                //if reserve ammo is less then reload ammo
                if (ReserveAmmo <= ReloadAvailable)
                {
                    
                    Ammo.LoadedAmmo += ReserveAmmo;
                    Ammo.CurrentAmmo -= ReserveAmmo;
                    ActionReload();
                }
                else
                {
                    Ammo.LoadedAmmo += ReloadAvailable;
                    Ammo.CurrentAmmo -= ReloadAvailable;
                    ActionReload();
                }
            }
            StartCoroutine(EnableScripts());

        }
    }

    IEnumerator EnableScripts()
    {
        //waits a second until pistol can be used
        yield return new WaitForSeconds(1.1f);
        PistolComponent.enabled = true;
    }

    void ActionReload()
    {
        //Reload animation and sound. Pistol becomes unuseable 
        PistolComponent.enabled = false;
        ReloadSound.Play();
        anim.Play("MakarovReload");
    }
}
