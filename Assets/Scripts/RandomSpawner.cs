using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject spherePrefab; // Definieren wir hier unsere Prefab-Referenz
    public int numberOfSpheres = 20;

    void Start()
    {
        for (int i = 0; i < numberOfSpheres; i++)
        {
            Vector3 randomPosition = new Vector3(
                Random.Range(-10f, 10f),
                Random.Range(1f, 4f),
                Random.Range(-10f, 10f) // Range ist wichtig. Falls das Range nicht eingestellt wird dann die Kugel leider nicht im Raum schweben
            );

            Instantiate(spherePrefab, randomPosition, Quaternion.identity);
        }
    }
}
