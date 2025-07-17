using UnityEngine;

public class FloatingMotion : MonoBehaviour
{
    private Vector3 startPos;

    void Start()
    {
        // Startposition speichern
        startPos = transform.position;
    }

    void Update()
    {
        // Schweben hinzufügen (nach oben/unten)
        float yOffset = Mathf.Sin(Time.time * 2f) * 0.3f;
        transform.position = new Vector3(
            startPos.x,
            startPos.y + yOffset,
            startPos.z
        );
    }
}
