using UnityEngine;

public class DataLogPickup : MonoBehaviour
{
    [SerializeField]
    GameEventGeneric<Vector3> onGoalReached;

    void OnTriggerEnter2D(Collider2D collision)
    {
        Robot robot = collision.gameObject.GetComponent<Robot>();
        if (robot != null && robot.IsActiveBot)
        {
            onGoalReached.Invoke(robot.transform.position);
        }
    }
}