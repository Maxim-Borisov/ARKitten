﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour {
    private Animation _animation;
    private bool _inAction;
 
    void Start () {
        _animation = GetComponent<Animation>();
	}

    private void ResetAnimation()
    {
        _inAction = false;
        _animation.Play("Idle");
    }

    public void Meow()
    {
        if (_inAction)
        {
            return;
        }

        _inAction = true;
        _animation.Play("Meow");
        Invoke("ResetAnimation", 1.10f);
    }

    public void Itch()
    {
        if(_inAction)
        {
            return;
        }

        _inAction = true;
        _animation.Play("Ithcing");
        Invoke("ResetAnimation", 1.25f);
    }

    public void Sit()
    {
        if (_inAction)
        {
            return;
        }

        _inAction = true;
        _animation.Play("IdleSit");
        Invoke("ResetAnimation", 3.25f);
    }
}
