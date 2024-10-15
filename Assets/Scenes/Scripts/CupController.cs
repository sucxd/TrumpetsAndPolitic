using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class CupController : MonoBehaviour
{
    private Animator cupAnimator;
    private XRGrabInteractable grabInteractable;
    private Rigidbody cupRigidbody;
    // Define a flag to check if animation is finished
    private bool isAnimationFinished = false;

    void Start()
    {
        // Initialize components
        cupAnimator = GetComponent<Animator>();
        grabInteractable = GetComponent<XRGrabInteractable>();
        cupRigidbody = GetComponent<Rigidbody>();

        // Disable grab functionality initially
        grabInteractable.enabled = false;
    }

    // Function to trigger the animation
    public void OnButtonClicked()
    {
        // Set the 'Up' parameter in the animator to trigger the animation
        cupAnimator.SetBool("Up", true);

        // Disable grab during animation
        grabInteractable.enabled = false;

        // Optionally, freeze Rigidbody movement during the animation
        cupRigidbody.isKinematic = true;
    }

    // Unity event function that runs when an animation ends
    void OnAnimationComplete()
    {
        // This will be called when the animation finishes
        isAnimationFinished = true;

        // Enable grabbing functionality
        grabInteractable.enabled = true;

        // Unfreeze the Rigidbody so it can be interacted with
        cupRigidbody.isKinematic = false;
    }

    void Update()
    {
        // Check if animation has ended and set the animator back to default
        if (isAnimationFinished && cupAnimator.GetCurrentAnimatorStateInfo(0).IsName("CUP_Animation"))
        {
            // Reset the animation so it doesn’t loop
            cupAnimator.SetBool("Up", false);
            isAnimationFinished = false;
        }
    }
}
