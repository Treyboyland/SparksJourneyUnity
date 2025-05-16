using UnityEngine;

public class PlayerSpark : MonoBehaviour
{
    [SerializeField]
    float maxMovementDistance;

    [SerializeField]
    float speed;

    [SerializeField]
    Rigidbody2D body;

    [SerializeField]
    GameEventGeneric<Vector3> onActivated;

    Vector3 anchorPosition;

    public void Activate(Vector3 startPos)
    {
        transform.position = startPos;
        anchorPosition = startPos;
        onActivated.Invoke(startPos);
        gameObject.SetActive(true);
    }

    void FixedUpdate()
    {
        if (Vector3.Distance(anchorPosition, transform.position) > maxMovementDistance)
        {
            Vector3 norm = (transform.position - anchorPosition).normalized;
            body.MovePosition(anchorPosition + norm);
        }
    }

}