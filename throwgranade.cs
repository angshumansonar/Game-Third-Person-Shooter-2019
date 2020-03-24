using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class throwgranade : MonoBehaviour
{
    public GameObject granadeprefab1;
    public GameObject granadeprefab2;
    public Transform hand;
    public float throwgranadeforce = 10f;

    public static float granade1=0;
    public static float granade2=0;

    private int maxgr1 = 6;
    private int maxgr2 = 6;

    public Text granade1text;
    public Text granade2text;

    public Image granade110;
    public Image granade220;

    public bool wait;

    public AudioSource throwgn12sfx;
    public AudioSource pickupgn12sfx;


    public void OnCollisionEnter(Collision collision)
    {


        if (collision.transform.tag == "granadepack1")
        {


            if (granade1 < maxgr1)
            {
                granade1 += 1;
                pickupgn12sfx.Play();
                granade1text.text =granade1.ToString();

                Destroy(collision.gameObject);
            }


        }

        if (collision.transform.tag == "granadepack2")
        {


            if (granade2 < maxgr2)
            {
                granade2 += 1;
                pickupgn12sfx.Play();
                granade2text.text =granade2.ToString();
                Destroy(collision.gameObject);
            }


        }


    }

    // Update is called once per frame
    void Update()
    {
        if(wait)
        {
            return;
        }

        if (granade1 == 0)
        {
            granade110.color = Color.red;
        }
        
        


        if (granade1>0)
        {
            granade110.color = Color.white;


            if (carcontroller.isrun == false && carcontroller.isidel == true)
            {
                if (Input.GetKeyDown(KeyCode.K))
                {
                    throwgn12sfx.Play();
                    granade1 = granade1 - 1;
                    granade1text.text = granade1.ToString();
                    Invoke("myinstance1", 0.5f);  
                    StartCoroutine(waitt());
                   
                }

            }
           
        }

        if (granade2 == 0)
        {
            granade220.color = Color.red;
        }

        if (granade2 > 0)
        {
            granade220.color = Color.white;

            if (carcontroller.isrun == false && carcontroller.isidel == true)
            {
                if (Input.GetKeyDown(KeyCode.L))
                {
                    throwgn12sfx.Play();
                    granade2 = granade2 - 1;
                    granade2text.text = granade2.ToString();
                    Invoke("myinstance2", 0.5f);
                    StartCoroutine(waitt());
                    
                }
            }

               
        }
    }




    void myinstance1()
    {
        GameObject gren = Instantiate(granadeprefab1, hand.position, hand.rotation) as GameObject;
        gren.GetComponent<Rigidbody>().AddForce(hand.forward * throwgranadeforce, ForceMode.Impulse);
    }

    void myinstance2()
    {
        GameObject gren = Instantiate(granadeprefab2, hand.position, hand.rotation) as GameObject;
        gren.GetComponent<Rigidbody>().AddForce(hand.forward * throwgranadeforce, ForceMode.Impulse);
    }

    IEnumerator waitt()
    {
        wait = true;
        granade110.enabled = false;
        granade220.enabled = false;
        yield return new WaitForSeconds(2f);
        granade220.enabled = true;
        granade110.enabled = true;
        wait = false;
    }

}
