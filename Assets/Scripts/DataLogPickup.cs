using UnityEngine;

public class DataLogPickup : MonoBehaviour
{
    [SerializeField]
    GameEventGeneric<DataLogPickupData> onPickup;

    void OnTriggerEnter2D(Collider2D collision)
    {
        Robot robot = collision.gameObject.GetComponent<Robot>();
        if (robot != null && robot.IsActiveBot)
        {
           DataLogPickupData data = new DataLogPickupData(); onPickup.Invoke(data);
        }
    }
}