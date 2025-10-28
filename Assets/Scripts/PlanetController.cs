using UnityEngine;

public class PlanetController : MonoBehaviour
{
    // This is now the amount of degrees it will rotate with each click.
    public float rotationAmount = 10.0f;

    // This public function will be called by the UI buttons.
    public void RotatePlanet(int direction)
    {
        // We rotate the object by a fixed amount (rotationAmount) in the given direction.
        // We have removed Time.deltaTime.
        transform.Rotate(Vector3.up, rotationAmount * direction);
    }
}