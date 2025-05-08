using System.Collections.Generic;
using UnityEngine;

public class GameEvent : MonoBehaviour
{
    List<GameEventListener> listeners = new List<GameEventListener>();

    public void AddListener(GameEventListener listener)
    {
        listeners.Add(listener);
    }

    public void RemoveListener(GameEventListener listener)
    {
        listeners.Remove(listener);
    }

    public virtual void Invoke()
    {
        foreach (GameEventListener listener in listeners)
        {
            if (listener != null)
            {
                listener.Response.Invoke();
            }
        }
    }
}
