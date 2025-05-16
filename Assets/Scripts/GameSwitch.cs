using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class GameSwitch : MonoBehaviour
{
    [SerializeField]
    GameEventGeneric<bool> onSwitchActiveState;

    [SerializeField]
    bool canBeTurnedOff;

    [SerializeField]
    float secondsActive;

    [SerializeField]
    bool currentState;

    float secondsElapsed;

    public bool CurrentState
    {
        get => currentState;
        set
        {
            currentState = value;
            onSwitchActiveState.Invoke(currentState);
            OnThisSwitchStateChanged.Invoke(currentState);
        }
    }

    public UnityEvent<bool> OnThisSwitchStateChanged;

    void Start()
    {
        onSwitchActiveState.Invoke(currentState);
    }

    void Update()
    {
        if (currentState && secondsActive > 0)
        {
            secondsElapsed += Time.deltaTime;
            if (secondsElapsed >= secondsActive)
            {
                secondsElapsed = 0;
                CurrentState = false;
            }
        }
    }

    void SwitchHit()
    {
        if (currentState && !canBeTurnedOff)
        {
            return;
        }

        CurrentState = !CurrentState;
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        var player = collider.gameObject.GetComponent<Robot>();
        if (player.IsActiveBot)
        {
            SwitchHit();
        }
    }

}