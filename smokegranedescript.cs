using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smokegranedescript : MonoBehaviour
{
    public float delay = 3f;
    public bool hasexplode = false;
    public GameObject explosionefffect;
    public AudioSource gnhitsfx;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        delay -= Time.deltaTime;
        if (delay <= 0 && !hasexplode)
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
       

        Destroy(gameObject);
    }
}
