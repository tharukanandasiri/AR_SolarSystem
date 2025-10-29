using UnityEngine;

public class PlanetOrbit : MonoBehaviour
{
    public Transform sun;

    public float orbitSpeed;

    public float rotationSpeed = 50.0f;

    void Update()
    {
        if (sun != null)
        {
            transform.RotateAround(sun.position, Vector3.up, orbitSpeed * Time.deltaTime);

            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }
    }
}