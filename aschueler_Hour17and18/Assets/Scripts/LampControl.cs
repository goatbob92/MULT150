using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampControl : MonoBehaviour
{
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            anim.SetTrigger("WKey");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            anim.SetTrigger("SKey");
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            anim.SetTrigger("AKey");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            anim.SetTrigger("DKey");
        }
    }
}
