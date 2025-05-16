using UnityEngine;

public class PeriodicMove : MonoBehaviour
{
    [SerializeField]
    Vector3 movementVector;

    [SerializeField]
    float revolutionsPerSeconds;

    Vector3 initialPosition;

    void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
        transform.position = initialPosition + Mathf.Cos(2 * Mathf.PI * Time.deltaTime) * movementVector;
    }
}