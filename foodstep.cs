using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foodstep : MonoBehaviour
{
    public AudioSource groundsfx;
    public AudioSource cementsfx;
    public AudioSource wooodsfx;
    public AudioSource grasssfx;
    public AudioSource metalsfx;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Ground")
        {
            groundsfx.Play();
        }
        else if (collision.transform.tag == "cementcement")
        {
            cementsfx.Play();
        }
        else if (collision.transform.tag == "woodwood")
        {
            wooodsfx.Play();
        }
        else if (collision.transform.tag == "grass")
        {
            grasssfx.Play();
        }
        else if (collision.transform.tag == "metalmetal")
        {
            metalsfx.Play();
        }
        

    }


}
