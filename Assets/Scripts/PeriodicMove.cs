using UnityEngine;

public class PeriodicMove : MonoBehaviour
{
    [SerializeField]
    Vector2 movementVector;

[SerializeField]
float revolutionsPerSeconds;

Vector3 initialPosition;

void Start ()
{
initialPosition = transform.position;
}

    void Update()
{
transform.position = initialPosition + 2 * Math.PI * Time.deltaTime * initialPosition;
}
}