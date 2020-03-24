
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Target : MonoBehaviour
{
 
    public static float health = 100f;
    public static float shieldpower;
    public bool shield;
   public Image eff;
   public Image eff1;
    public Image eff2;
    public Image eff3;

    public Image deadeff;
    public Image deadeff1;
    public Image deadeff2;

    public Image deadeffss;
    public Image deadeffss1;
    public Image deadeffss2;

    public AudioSource shieldsfx;
    //public Text healthtext;
    // public GameObject secondcamera;
    // public GameObject maincamera;

    private void Start()

    {

        deadeff.enabled = false;
        deadeff1.enabled = false;
        deadeff2.enabled = false;

        deadeffss.enabled = false;
        deadeffss1.enabled = false;
        deadeffss2.enabled = false;

        shield = false;
        eff.enabled = false;
        eff1.enabled = false;
        eff2.enabled = false;

        eff3.enabled = true;

        //secondcamera = GetComponent<GameObject>();
        //maincamera = GetComponent<GameObject>();
        // maincamera.SetActive(true);
        // secondcamera.SetActive(false);
    }

    private void Update()
    {
        if (shield)
        {
            eff.enabled = true;
            eff1.enabled = true;
            eff2.enabled = true;
            eff3.enabled = false;

        }
        if (!shield)
        {
            eff.enabled = false;
            eff1.enabled = false;
            eff2.enabled = false;
            eff3.enabled = true;
        }


    }

    public void takedamage(float amount)
    {
        if (shield)
        {
           
            shieldpower -= amount/2;
            StartCoroutine(Blackoutss());

            // healthtext.text = health.ToString();
            if (shieldpower <= 0f)
            {
                shield=false;

                deadeffss.enabled = false;
                deadeffss1.enabled = false;
                deadeffss2.enabled = false;
            }
            
        }

        if (!shield)
        {
           
            health -= amount;
            StartCoroutine(Blackout());
            

            //yield return new WaitForSeconds(0.2f);


            // healthtext.text = health.ToString();
            if (health <= 0f)
            {
                deadeff.enabled = false;
                deadeff1.enabled = false;
                deadeff2.enabled = false;

                die();

            }

           

        }


    }
   
    void die()
    {
        //maincamera.SetActive(false);
        //secondcamera.SetActive(true);
        Destroy(gameObject);
        return;
    }

    public void OnCollisionEnter(Collision collision)
    {


        if (collision.transform.tag == "shield007")
        {


            if (!shield)
            {
                shield=true;
                shieldpower = 100f;
                shieldsfx.Play();
                Destroy(collision.gameObject);
            }
            

        }


    }

    IEnumerator Blackout()
    {
        deadeff.enabled = true;
        deadeff1.enabled = true;
        deadeff2.enabled = true;
        yield return new WaitForSeconds(0.07f);
        deadeff.enabled = false;
        deadeff1.enabled = false;
        deadeff2.enabled = false;
    }

    IEnumerator Blackoutss()
    {
        deadeffss.enabled = true;
        deadeffss1.enabled = true;
        deadeffss2.enabled = true;
        yield return new WaitForSeconds(0.07f);
        deadeffss.enabled = false;
        deadeffss1.enabled = false;
        deadeffss2.enabled = false;
    }

}
