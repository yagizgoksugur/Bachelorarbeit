using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    // Das Objekt, das für die Farbe zuständig ist
    private Renderer rend;

    // Beim Start holen wir uns den Renderer vom Objekt
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Diese Methode ändern die Farbe zufällig
    public void ChangeColor()
    {
        // Zufällige Farbe erzeugen mit RGB values
        Color neueFarbe = new Color(Random.value, Random.value, Random.value);

        // Die neue Farbe dem Material geben
        rend.material.color = neueFarbe;
    }

    // Wenn du mit der Maus testest → klick = Farbe ändern
    void OnMouseDown()
    {
        ChangeColor();
    }
}
