using UnityEngine;

public class OrbitController : MonoBehaviour
{
    private PlanetOrbit[] planets;
    private bool isOrbiting = false;

    void Start()
    {
        planets = GetComponentsInChildren<PlanetOrbit>();

        foreach (PlanetOrbit planet in planets)
        {
            planet.enabled = false;
        }
    }

    public void ToggleOrbit()
    {
        isOrbiting = !isOrbiting;

        foreach (PlanetOrbit planet in planets)
        {
            planet.enabled = isOrbiting;
        }
    }
}