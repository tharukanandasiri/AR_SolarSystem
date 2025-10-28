using UnityEngine;

public class OrbitController : MonoBehaviour
{
    // Public variable to control the speed of the orbit
    public float orbitSpeed = 10.0f;

    // A boolean to track if the planets should be orbiting
    private bool isOrbiting = false;

    // Update is called once per frame
    void Update()
    {
        // If isOrbiting is true, then rotate the object continuously
        if (isOrbiting)
        {
            // Rotate the pivot object this script is attached to
            transform.Rotate(Vector3.up, orbitSpeed * Time.deltaTime);
        }
    }

    // This public function will be called by our UI button to toggle the orbit on and off
    public void ToggleOrbit()
    {
        isOrbiting = !isOrbiting; // This flips the value from true to false, or false to true
    }
}