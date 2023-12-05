using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ECM.Controllers;

public class Player_Move : MonoBehaviour
{

    public Animator anim;
    public BaseCharacterController controller;
    // Start is called before the first frame update
    void Start()
    {
        anim = FindObjectOfType<Animator>();
        controller = FindObjectOfType<BaseCharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        OnRun();
        OnJump();
        OnAttack();
    }


    private void OnRun()
    {
        if(Input.GetKey(KeyCode.W))
        {
            anim.SetBool("isRun", true);
        }
        else
        {
            anim.SetBool("isRun", false);
        }
    }

    private void OnJump()
    {
        if(Input.GetKeyDown(KeyCode.Space)&& controller.isGrounded)
        {
            anim.SetTrigger("isJump");
        }
    }

    private void OnAttack()
    {
        if(Input.GetMouseButtonDown(0))
        {
            anim.SetTrigger("isAttack");
        }
    }
}
