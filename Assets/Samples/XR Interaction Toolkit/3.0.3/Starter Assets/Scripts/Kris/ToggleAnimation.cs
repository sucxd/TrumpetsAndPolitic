using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class ToggleAnimation : MonoBehaviour
{
    public Animator animator;
    private bool isOpen = false;

    public void ToggleDoor()
    {
        isOpen = !isOpen; // Toggle the boolean
        animator.SetBool("isOpen", isOpen); // Set the Animator parameter
    }
}
