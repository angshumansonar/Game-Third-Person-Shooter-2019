using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponswitching : MonoBehaviour
{
    public int selectedweapon = 0;

    //public AudioSource switchingsfx;

    // Start is called before the first frame update
    void Start()
    {
        selectweapon();
    }

    // Update is called once per frame
    void Update()
    {
        int previousSelectedWeapon = selectedweapon;

       if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            selectedweapon = 0;
        }
       if (Input.GetKeyDown(KeyCode.Alpha2))
        {
           
            selectedweapon = 1;
        }
       if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            
            selectedweapon = 2;
       }
       if (Input.GetKeyDown(KeyCode.Alpha4))
       {

            selectedweapon = 3;
       }
        



        if (previousSelectedWeapon!=selectedweapon)
        {
            //switchingsfx.Play();
            selectweapon();
           
        }
    }
    void selectweapon()
    {
        
        int i = 0;
        foreach(Transform weapon in transform)
        {
            if (i == selectedweapon)
            {
                
                weapon.gameObject.SetActive(true);
                /*scopeview.iszoom = false;
                scopeview2.iszoom = false;
                scopeview3.iszoom = false;*/
            }
            else
                weapon.gameObject.SetActive(false);
            i++;
           
            
        }
    }
}
