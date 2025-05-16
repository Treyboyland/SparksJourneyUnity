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

[SerializeField]
GameEventGeneric<Vector3> onDeactivated;

    Vector3 anchorPosition;

    public void Activate(Vector3 startPos)
    {
        transform.position = startPos;
        anchorPosition = startPos;
        onActivated.Invoke(startPos);
        gameObject.SetActive(true);
    }

public void Deactivate()
{
onDeactivated.Invoke(transform.position);
gameObject.SetActive(false);
}

    void FixedUpdate()
    {
        if (Vector3.Distance(anchorPosition, transform.position) > maxMovementDistance)
        {
            Vector3 norm = (transform.position - anchorPosition).normalized;
            body.MovePosition(anchorPosition + norm);
        }
    }


public void OnTriggerEnter2D(Collider2D collider)
{
var bot = collider.gameObject.GetCOmponent<Robot>();
if(bot)
{
bot.IsActiveBot = true;
Deactivate();
}
}
}