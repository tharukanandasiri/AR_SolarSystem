using UnityEngine;

public class PlanetOrbit : MonoBehaviour
{
    public Transform sun;

    public float orbitSpeed;

    void Update()
    {
        if (sun != null)
        {
            transform.RotateAround(sun.position, Vector3.up, orbitSpeed * Time.deltaTime);
        }
    }
}