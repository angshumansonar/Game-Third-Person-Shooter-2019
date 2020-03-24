using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ammopickup3 : MonoBehaviour
{
    
    private int totalmaxammo = 300;

    public Text ammotext;

    public AudioSource g3sfx;


    public void OnCollisionEnter(Collision collision)
    {


        if (collision.transform.tag == "ammopack3")
        {


            if (Gunpoint3.totalammo < totalmaxammo)
            {
                Gunpoint3.totalammo +=50;
                g3sfx.Play();
                Destroy(collision.gameObject);
            }


        }


    }

    private void Update()
    {
        if (Gunpoint3.totalammo > totalmaxammo)
        {
            Gunpoint3.totalammo = totalmaxammo;


        }

        if (Gunpoint3.totalammo <= 0f && Gunpoint3.currentAmmo != 0f)
        {
            ammotext.text = "low Ammo";
            ammotext.color = Color.yellow;
        }
        else if (Gunpoint3.totalammo <= 0f && Gunpoint3.currentAmmo == 0f)
        {
            ammotext.text = "No Ammo";
            ammotext.color = Color.red;
        }
        else if (Gunpoint3.totalammo == totalmaxammo)
        {
            ammotext.text = "Full Ammo";
            ammotext.color = Color.green;
        }
        else
        {
            ammotext.text = " ";
        }
    }

}
