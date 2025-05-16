using UnityEngine;

public class DataLogPickup : MonoBehaviour
{
    [SerializeField]
    DataLog log;

    [SerializeField]
    GameEventGeneric<DataLogPickupData> onPickup;

    void OnTriggerEnter2D(Collider2D collision)
    {
        Robot robot = collision.gameObject.GetComponent<Robot>();
        if (robot != null && robot.IsActiveBot)
        {
            DataLogPickupData data = new DataLogPickupData();
            data.DataLog = log;
            data.PickupPosition = robot.transform.position;
            onPickup.Invoke(data);
        }
    }
}