using UnityEngine;
using UnityEngine.InputSystem;

public class FlashlightToggle : MonoBehaviour
{
    public Light flashlight; // Reference to the flashlight's Light component
    public InputActionProperty toggleAction; // Input action to toggle flashlight

    private bool isFlashlightOn = false; // To track the flashlight's state

    private void OnEnable()
    {
        // Subscribe to the input action event
        toggleAction.action.performed += ToggleFlashlight;
        Debug.Log("Subscribed to flashlight toggle action.");
    }

    private void OnDisable()
    {
        // Unsubscribe from the input action event
        toggleAction.action.performed -= ToggleFlashlight;
        Debug.Log("Unsubscribed from flashlight toggle action.");
    }

    private void ToggleFlashlight(InputAction.CallbackContext context)
    {
        isFlashlightOn = !isFlashlightOn; // Toggle the flashlight state
        flashlight.enabled = isFlashlightOn; // Turn the flashlight on or off

        // Log when the flashlight is toggled
        Debug.Log("Flashlight toggled: " + (isFlashlightOn ? "On" : "Off"));
    }
}