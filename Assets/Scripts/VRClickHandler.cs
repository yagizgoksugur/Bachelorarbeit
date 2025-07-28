using UnityEngine;
using Valve.VR;

public class VRClickHandler : MonoBehaviour
{
    public SteamVR_Input_Sources handType = SteamVR_Input_Sources.LeftHand;
    public SteamVR_Action_Boolean grabAction;
    public LayerMask interactableLayer;
    public float maxDistance = 100f;

    private void Update()
    {
        if (grabAction.GetStateDown(handType))
        {
            Ray ray = new Ray(transform.position, transform.forward);
            if (Physics.Raycast(ray, out RaycastHit hit, maxDistance, interactableLayer))
            {
                Debug.Log("Hit object: " + hit.collider.name);
                var colorChanger = hit.collider.GetComponent<ColorChanger>();
                if (colorChanger != null)
                {
                    colorChanger.ChangeColor();
                }
            }
        }
    }
}
