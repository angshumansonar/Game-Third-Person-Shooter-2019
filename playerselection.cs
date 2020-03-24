using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playerselection : MonoBehaviour
{

    public int selectedweapon = 0;
    public int index = 0;

    //public AudioSource switchingsfx;

    
    void Start()
    {
        selectweapon();
       
    }

    
    void Update()
    {
        int previousSelectedWeapon = selectedweapon;

        if (selectedweapon <= 8)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {

                selectedweapon = selectedweapon + 1;
            }
        }
           
        if(selectedweapon>=1)
        {
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {

                selectedweapon = selectedweapon - 1;
            }
        }
       
        
        if (previousSelectedWeapon != selectedweapon)
        {
           // switchingsfx.Play();
            selectweapon();

        }
    }
    void selectweapon()
    {

        int i = 0;
        foreach (Transform weapon in transform)
        {
            if (i == selectedweapon)
            {

                weapon.gameObject.SetActive(true);
                
            }
            else
                weapon.gameObject.SetActive(false);
            i++;


        }
    }
   
}
