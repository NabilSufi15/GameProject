using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Source: Jimmy Vegas- How To Make an FPS

public class Ammo : MonoBehaviour
{
    public static int CurrentAmmo;
    public int InternalAmmo;
    public GameObject ammo;

    public static int LoadedAmmo;
    public int InternalLoaded;
    public GameObject AmmoCapacity;


    void Update()
    {
        //constantly updates how much current ammo and loaded ammo is remaining
        InternalAmmo = CurrentAmmo;
        InternalLoaded = LoadedAmmo;
        ammo.GetComponent<Text>().text = "" + InternalAmmo;
        AmmoCapacity.GetComponent<Text>().text = LoadedAmmo + "/";
    }
}
