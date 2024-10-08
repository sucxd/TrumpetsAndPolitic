using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ObjectPicker : MonoBehaviour
{
    private Rigidbody rb;
    private Transform originalParent;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        originalParent = transform.parent; // Store the original parent
    }

    public void OnSelectEntered(SelectEnterEventArgs args)
    {
        // Called when the object is picked up
        rb.isKinematic = true; // Temporarily disable physics
        transform.SetParent(args.interactorObject.transform); // Parent it to the interactor
        transform.localPosition = Vector3.zero; // Reset position
    }

    public void OnSelectExited(SelectExitEventArgs args)
    {
        // Called when the object is released
        transform.SetParent(originalParent); // Reset parent
        rb.isKinematic = false; // Re-enable physics
    }

    void Update()
    {
        // Optional: You can add logic here to move the object smoothly if needed
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Handle collision events for debugging
        Debug.Log("Collided with: " + collision.gameObject.name);
    }
}
