using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Source: Jimmy Vegas- How To Make an FPS

public class PickupAmmo : MonoBehaviour
{
    public AudioSource AmmoSound;

    void OnTriggerEnter(Collider other)
    {
        // If Loaded Ammo is empty, add ammo into it
        AmmoSound.Play();
        if (Ammo.LoadedAmmo == 0)
        {
            Ammo.LoadedAmmo += 10;
            this.gameObject.SetActive(false);
        }
        //if Loaded Ammo is full, add ammo into Current Ammo
        else
        {
            Ammo.CurrentAmmo += 10;
            this.gameObject.SetActive(false);
        }
    }
}
