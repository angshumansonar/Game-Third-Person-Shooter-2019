using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ammopickup2 : MonoBehaviour
{


    private int totalmaxammo = 30;

    public Text ammotext;

    public AudioSource g2sfx;


    public void OnCollisionEnter(Collision collision)
    {


        if (collision.transform.tag == "ammopack2")
        {


            if (Gunpoint2.totalammo < totalmaxammo)
            {
                Gunpoint2.totalammo += 5;
                g2sfx.Play();
                Destroy(collision.gameObject);
            }


        }


    }

    private void Update()
    {
        if (Gunpoint2.totalammo > totalmaxammo)
        {
            Gunpoint2.totalammo = totalmaxammo;


        }

        if (Gunpoint2.totalammo <= 0f && Gunpoint2.currentAmmo != 0f)
        {
            ammotext.text = "low Ammo";
            ammotext.color = Color.yellow;
        }
        else if (Gunpoint2.totalammo <= 0f && Gunpoint2.currentAmmo == 0f)
        {
            ammotext.text = "No Ammo";
            ammotext.color = Color.red;
        }
        else if (Gunpoint2.totalammo == totalmaxammo)
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
