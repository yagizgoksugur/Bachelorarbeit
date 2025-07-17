using UnityEngine;
using Valve.VR;

public class ControllerClickHandler : MonoBehaviour
{
    // Welche Hand benutzen wir? (mit diesem Public Class definieren wir unser Controller)
    public SteamVR_Input_Sources handType;

    // Die Pose (Position + Richtung) vom Controller
    public SteamVR_Behaviour_Pose controllerPose;

  
    public SteamVR_Action_Boolean triggerAction;

    void Update()
    {
        // Wenn der Trigger einmal gedrückt wird
        if (triggerAction.GetStateDown(handType))
        {
            RaycastHit hit;

            // Schieße einen unsichtbaren Strahl nach vorne
            if (Physics.Raycast(controllerPose.transform.position, controllerPose.transform.forward, out hit, 100f))
            {
                // Wenn das getroffene Objekt ein ColorChanger-Script hat
                ColorChanger colorChanger = hit.collider.GetComponent<ColorChanger>();

                //dann Farbe ändern!
                if (colorChanger != null)
                {
                    colorChanger.ChangeColor();
                }
            }
        }
    }
}
