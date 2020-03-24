using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthfill : MonoBehaviour
{
    public int totalmaxhealthkit =5;
    public int totalmaxhealth = 100;

    public Text healthkitcarrytext;

    public int totalhealthkit;

    public Image helathkitno;

    public AudioSource healthboxsfx;

    private void Start()
    {
        totalhealthkit = 0;
        healthkitcarrytext.text = totalhealthkit.ToString();
    }

    public void OnCollisionEnter(Collision collision)
    {


        if (collision.transform.tag == "healthkit")
        {


            if (totalhealthkit<totalmaxhealthkit)
            {
                totalhealthkit += 1;
                healthboxsfx.Play();
                healthkitcarrytext.text = totalhealthkit.ToString();

                Destroy(collision.gameObject);
            }


        }


    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {


            if ((Target.health < totalmaxhealth)&&(totalhealthkit!=0))
            {
                Target.health += 10;
                totalhealthkit -= 1;
                healthkitcarrytext.text = totalhealthkit.ToString();

            }


        }
        if (totalhealthkit == 0)
        {
            helathkitno.enabled = true;
        }
        else
        {
            helathkitno.enabled =false;
        }


    }

}
