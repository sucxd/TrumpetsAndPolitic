using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleAnimation : MonoBehaviour
{
    public Animator animator;
    private bool isOpen = false;

    public void TogglePanel()
    {
        isOpen = !isOpen;
        animator.SetBool("isOpen", isOpen);
    }
}

