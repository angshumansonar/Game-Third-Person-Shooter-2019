using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aimupdown : MonoBehaviour
{
    public Transform targetreee;
    public Vector3 offset1;

    public Transform bodypart;
    public Animator anim;

      private void Start()
    {
      anim = GetComponent<Animator>();
    }

    void LateUpdate()
    {
        bodypart.LookAt(targetreee.position);
        bodypart.rotation = bodypart.rotation * Quaternion.Euler(offset1);
    }
}
