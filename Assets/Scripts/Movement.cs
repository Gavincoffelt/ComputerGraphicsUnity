using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Animator anim;
    private Rigidbody rb;
    public int ParamInt = 0;
    public float speed = 5;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        
    }

    void Update()
    {

        if (Input.GetKey(KeyCode.A) && anim.GetInteger("AnimState") != 4)
        {
            ParamInt = 1;
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("RUNL"))
            {
                rb.velocity = -gameObject.transform.right * speed;
            }
        }
        if (Input.GetKey(KeyCode.W) && anim.GetInteger("AnimState") != 4)
        {
            ParamInt = 2;
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("RUNF"))
            {
                rb.velocity = gameObject.transform.forward * speed;
            }
        }
        if (Input.GetKey(KeyCode.D) && anim.GetInteger("AnimState") != 4)
        {
            ParamInt = 3;
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("RUNR"))
            {
                rb.velocity = gameObject.transform.right * speed;
            }
        }
        if (Input.GetKey(KeyCode.S) && anim.GetInteger("AnimState") != 4)
        {
            ParamInt = 5;
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("RUNB"))
            {
                rb.velocity = -gameObject.transform.forward * speed;
            }
        }
        if (Input.GetKey(KeyCode.Space) && anim.GetInteger("AnimState") != 4)
        {
            ParamInt = 4;
            
        }
     
        if (!Input.anyKey)
        {
            ParamInt = 0;
        }
        anim.SetInteger("AnimState", ParamInt);
    }
}
