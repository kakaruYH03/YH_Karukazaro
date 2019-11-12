using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    Animator animator;

    protected virtual void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void Open()
    {
        animator.SetTrigger(Constant.kViewManagerOpen);
    }

    public void Close()
    {
        animator.SetTrigger(Constant.kViewManagerClose);
    }
}
