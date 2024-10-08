// using UnityEngine;
// using UnityEngine.Rendering;
// using UnityEngine.Rendering.Universal;

// public class EyeObjectDetection : MonoBehaviour
// {
//     public Camera mainCamera;
//     public float detectionDistance = 10f;
//     public string targetTag = "Interactable";
//     public Volume postProcessVolume;
//     private Vignette vignette;

//     private void Start()
//     {
//         postProcessVolume.profile.TryGet(out vignette);
//     }

//     private void Update()
//     {
//         bool objectDetected = DetectObject(mainCamera);

//         if (objectDetected)
//         {
//             ApplyVignette(0.5f);
//         }
//         else
//         {
//             ApplyVignette(0f);
//         }
//     }

//     private bool DetectObject(Camera eyeCamera)
//     {
//         Ray ray = new Ray(eyeCamera.transform.position, eyeCamera.transform.forward);
//         RaycastHit hit;

//         if (Physics.Raycast(ray, out hit, detectionDistance))
//         {
//             if (hit.collider.CompareTag(targetTag))
//             {
//                 return true;
//             }
//         }
//         return false;
//     }

//     private void ApplyVignette(float intensity)
//     {
//         if (vignette != null)
//         {
//             vignette.intensity.value = Mathf.Lerp(vignette.intensity.value, intensity, Time.deltaTime * 5f);
//         }
//     }
// }
