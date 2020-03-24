using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class carcontroller : MonoBehaviour
{


    public bool isgrounded;
    public bool iscrouching;
    public static bool isrun;
    public static bool isidel;

    public float speed = 1.55f;
    public float cspeed = 1.3f;
    public float rspeed = 4f;

    // public AudioSource jumpsound;


    Rigidbody rb;
    Animator anim;
    public CapsuleCollider colll;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        colll = colll.GetComponent<CapsuleCollider>();
        isgrounded = true;

    }

    void Update()
    {


        //crouch walk
        if (iscrouching)
        {

            transform.Translate(cspeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, cspeed * Input.GetAxis("Vertical") * Time.deltaTime);
        }
        else
        {

            transform.Translate(speed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, speed * Input.GetAxis("Vertical") * Time.deltaTime);
        }

        //run
        if (isrun)
        {

            transform.Translate(speed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, rspeed * Input.GetAxis("Vertical") * Time.deltaTime);
        }
        else
        {

            transform.Translate(speed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, speed * Input.GetAxis("Vertical") * Time.deltaTime);
        }

        //crouch
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (iscrouching)
            {
                iscrouching = false;
                colll.height = 1f;
                anim.SetBool("crouchidel", false);
            }
            else
            {
                iscrouching = true;
                colll.height = 0.55f;
                anim.SetBool("crouchidel", true);

            }
        }

        //jump
        if (isgrounded && !iscrouching)
        {
            if (Input.GetButtonDown("Jump"))
            {
                rb.velocity = new Vector3(0f, 6.5f, 0f);
                iscrouching = false;
                isgrounded = false;
                anim.SetBool("jump", true);
                //jumpsound.Play();
            }


        }
        if (isgrounded && iscrouching)
        {
            if (Input.GetButtonDown("Jump"))
            {
                rb.velocity = new Vector3(0f, 6.5f, 0f);
                iscrouching = true;
                isgrounded = false;
                anim.SetBool("jump", true);
                // jumpsound.Play();
            }

        }





        //stand movement
        if (!iscrouching && isgrounded)
        {
            if (Input.GetKey(KeyCode.W))
            {
                anim.SetBool("walkingfront", true);
            }
            else
            {
                anim.SetBool("walkingfront", false);
            }


            if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift))
            {
                isrun = true;
                anim.SetBool("running", true);
            }
            else
            {
                isrun = false;
                anim.SetBool("running", false);
            }

            if (Input.GetKey(KeyCode.S))
            {
                anim.SetBool("walkingback", true);
            }
            else
            {
                anim.SetBool("walkingback", false);
            }

            if (Input.GetKey(KeyCode.A))
            {
                anim.SetBool("walkingleft", true);
            }
            else
            {
                anim.SetBool("walkingleft", false);
            }

            if (Input.GetKey(KeyCode.D))
            {
                anim.SetBool("walkingright", true);
            }
            else
            {
                anim.SetBool("walkingright", false);
            }

            if (!isrun && isidel)
            {
                if ((Input.GetKeyDown(KeyCode.K) && throwgranade.granade1 > 0) || (Input.GetKeyDown(KeyCode.L) && throwgranade.granade2 > 0))
                {
                    anim.SetTrigger("standthrowgn");
                }

            }
        }




        //crouch movement
        if (iscrouching && isgrounded)
        {
            if (Input.GetKey(KeyCode.W))
            {
                anim.SetBool("crouchfront", true);
            }
            else
            {
                anim.SetBool("crouchfront", false);
            }


            if (Input.GetKey(KeyCode.S))
            {
                anim.SetBool("crouchback", true);
            }
            else
            {
                anim.SetBool("crouchback", false);
            }

            if (Input.GetKey(KeyCode.A))
            {
                anim.SetBool("crouchleft", true);
            }
            else
            {
                anim.SetBool("crouchleft", false);
            }

            if (Input.GetKey(KeyCode.D))
            {
                anim.SetBool("crouchright", true);
            }
            else
            {
                anim.SetBool("crouchright", false);
            }

            if (!isrun && isidel)
            {
                if ((Input.GetKeyDown(KeyCode.K) && throwgranade.granade1 > 0) || (Input.GetKeyDown(KeyCode.L) && throwgranade.granade2 > 0))
                {
                    anim.SetTrigger("crouchthrowgn");
                }

            }
        }

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetButton("Jump"))
        {
            isidel = false;
        }
        else
        {
            isidel = true;
        }
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.transform.tag == "Ground")
        {
            isgrounded = true;
            anim.SetBool("jump", false);
        }

        if (other.transform.tag == "cementcement")
        {
            isgrounded = true;
            anim.SetBool("jump", false);
        }

        if (other.transform.tag == "woodwood")
        {
            isgrounded = true;
            anim.SetBool("jump", false);
        }

        if (other.transform.tag == "grass")
        {
            isgrounded = true;
            anim.SetBool("jump", false);
        }

        if (other.transform.tag == "metalmetal")
        {
            isgrounded = true;
            anim.SetBool("jump", false);
        }


    }
}
