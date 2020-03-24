using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gnade2script : MonoBehaviour
{
    public float delay = 3f;
    public bool hasexplode=false;
    public GameObject explosionefffect;
    public float blastredious = 5f;
    public float damage = 120f;
    public AudioSource gnhitsfx;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        delay -= Time.deltaTime;
        if(delay<=0 && !hasexplode)
        {
            explode();
            hasexplode = true;
           
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        gnhitsfx.Play();
    }

    void explode()
    {
        Instantiate(explosionefffect, transform.position, transform.rotation);

       Collider[] colliders= Physics.OverlapSphere(transform.position, blastredious);

        foreach(Collider col in colliders)
        {
            Target target = col.GetComponent<Target>();
            if(target !=null)
            {
                target.takedamage(damage);
            }
        }
       
        Destroy(gameObject);
    }
}
