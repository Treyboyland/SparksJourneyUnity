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
    float swapDelay;

    [SerializeField]
    GameEventGeneric<Vector3> onActivated;

    [SerializeField]
    GameEventGeneric<Vector3> onDeactivated;

    [SerializeField]
    GameEventGeneric<Transform> onChangeCameraFocus;

    Vector3 anchorPosition;

    public Vector3 AnchorPosition { get => anchorPosition; }

    float secondsSinceMerged;

    Vector2 movementVector;

    void Update()
    {
        secondsSinceMerged += Time.deltaTime;
    }

    void OnEnable()
    {
        secondsSinceMerged = 0;
        movementVector = Vector2.zero;
    }

    public void Activate(Vector3 startPos)
    {
        transform.position = startPos;
        anchorPosition = startPos;
        gameObject.SetActive(true);
        onActivated.Invoke(startPos);
        onChangeCameraFocus.Invoke(transform);
    }

    public void Deactivate()
    {
        onDeactivated.Invoke(transform.position);
        gameObject.SetActive(false);
    }

    void FixedUpdate()
    {
        body.MovePosition((Vector2)transform.position + movementVector * Time.fixedDeltaTime * speed);
        if (Vector3.Distance(anchorPosition, transform.position) > maxMovementDistance)
        {
            Vector3 norm = (transform.position - anchorPosition).normalized;
            body.MovePosition(anchorPosition + norm * maxMovementDistance * 0.98f);
        }
    }

    public void Move(Vector2 movementVector)
    {
        if (gameObject.activeInHierarchy)
        {
            this.movementVector = movementVector;
        }
    }

    public void OnTriggerEnter2D(Collider2D collider)
    {
        var bot = collider.gameObject.GetComponent<Robot>();
        if (bot && secondsSinceMerged > swapDelay)
        {
            bot.IsActiveBot = true;
            Deactivate();
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        var bot = collision.gameObject.GetComponent<Robot>();
        if (bot && secondsSinceMerged > swapDelay)
        {
            bot.IsActiveBot = true;
            Deactivate();
        }
    }
}