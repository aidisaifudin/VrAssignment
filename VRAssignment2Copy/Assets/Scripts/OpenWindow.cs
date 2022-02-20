﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenWindow : UseItemOnThis
{
    //Change the code here ***************************
    public Animator animator;
    public AudioSource audio;
    public AudioClip dooropenclip, doorstuckclip, doorunlockclip;
    //************************************************

    void Start()
    {

    }

    public override void DoesntWork()
    {
        //Change the code here ***************************
        audio.PlayOneShot(doorstuckclip);
        //**************************************************
    }

    public override void FirstUnlockInstance()
    {
        //Change the code here ***************************
        animator.SetTrigger("WindowOpen");
        audio.PlayOneShot(doorunlockclip);
        //**************************************************
        SetItemAsUsed();
    }

    public override void SubsequentActivation_IfAny()
    {
        //Change the code here ***************************
        animator.SetTrigger("WindowClose");
        audio.PlayOneShot(dooropenclip);
        //**************************************************
    }

}
