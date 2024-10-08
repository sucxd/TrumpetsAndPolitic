using UnityEngine;

public class VelocityTracker : MonoBehaviour
{
    private Rigidbody rb;

    // To store the previous position for calculating velocity
    private Vector3 previousPosition;
    private Vector3 velocity;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        previousPosition = transform.position; // Initialize previous position
    }

    void FixedUpdate()
    {
        // Calculate velocity by comparing current position to previous position
        Vector3 currentPosition = transform.position;
        velocity = (currentPosition - previousPosition) / Time.fixedDeltaTime; // Calculate velocity
        previousPosition = currentPosition; // Update previous position for the next frame

        // Optionally, you can log or use the velocity for other purposes
        Debug.Log("Current Velocity: " + velocity);
    }

    public Vector3 GetVelocity()
    {
        return velocity; // This can be called from other scripts to get the current velocity
    }
}