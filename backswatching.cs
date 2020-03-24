using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backswatching : MonoBehaviour
{
    public int selectedweapon = 0;

    // Start is called before the first frame update
    void Start()
    {
        selectweapon();
    }

    // Update is called once per frame
    void Update()
    {
        int previousSelectedWeapon = selectedweapon;

        if (Input.GetKeyDown(KeyCode.Alpha1))
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



        if (previousSelectedWeapon != selectedweapon)
        {
            selectweapon();
        }
    }
    void selectweapon()
    {
        int i = 0;
        foreach (Transform weaponback in transform)
        {
            if (i == selectedweapon)
                weaponback.gameObject.SetActive(false);
            else
                weaponback.gameObject.SetActive(true);
            i++;


        }
    }

}
