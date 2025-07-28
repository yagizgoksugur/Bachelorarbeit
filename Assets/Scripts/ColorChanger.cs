using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    private Renderer rend;

    private void Start()
    {
        rend = GetComponent<Renderer>();
    }

    public void ChangeColor()
    {
        Debug.Log("ChangeColor() called on " + gameObject.name);
        rend.material.color = new Color(Random.value, Random.value, Random.value);
    }
}
