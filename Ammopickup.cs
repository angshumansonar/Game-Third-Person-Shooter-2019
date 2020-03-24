using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ammopickup : MonoBehaviour
{
    private int totalmaxammo = 150;

    public Text ammotext;

    public AudioSource g1sfx;

    public void OnCollisionEnter(Collision collision)
    {
      

        if (collision.transform.tag == "ammopack")
        {


            
            

            if (Gunpoint.totalammo<totalmaxammo)
            {
                Gunpoint.totalammo +=25;
                g1sfx.Play();


                Destroy(collision.gameObject);
            }

           

        }




    }


    public void Update()
    {
        if (Gunpoint.totalammo > totalmaxammo)
        {
            Gunpoint.totalammo =totalmaxammo;
        }

        if (Gunpoint.totalammo <= 0f && Gunpoint.currentAmmo != 0f)
        {
            ammotext.text = "low Ammo";
            ammotext.color = Color.yellow;   
        }
        else if (Gunpoint.totalammo <= 0f && Gunpoint.currentAmmo == 0f)
        {
            ammotext.text = "No Ammo";
            ammotext.color = Color.red;
        }
        else if (Gunpoint.totalammo == totalmaxammo)
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



