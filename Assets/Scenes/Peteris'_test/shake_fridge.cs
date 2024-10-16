using UnityEngine;

public class FridgeShaker : MonoBehaviour
{
    public Rigidbody fridgeRigidbody;
    public float shakeForce = 2.0f; // Adjust this for how much the fridge should shake
    
    // This will be called when the player's hand enters the trigger collider
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerHand")) // Make sure the hand/controller has this tag
        {
            Debug.Log("Player hand entered fridge trigger zone.");
        }
    }

    // Called while the player's hand is still in the trigger area
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("PlayerHand"))
        {
            // Apply random shaking force
            Vector3 randomShake = new Vector3(
                Random.Range(-shakeForce, shakeForce),
                0, // No vertical force (Y-axis), so it doesn't move up or down
                Random.Range(-shakeForce, shakeForce)
            );

            fridgeRigidbody.AddTorque(randomShake); // Apply the shake as rotational force
        }
    }

    // This is called when the player's hand exits the trigger collider
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("PlayerHand"))
        {
            Debug.Log("Player hand left the fridge trigger zone.");
        }
    }
}
