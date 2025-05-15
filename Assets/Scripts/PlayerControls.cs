using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControls : MonoBehaviour
{
    [SerializeField]
    GameEventGeneric<Vector2> onMove;

    [SerializeField]
    GameEvent onAbility;

    [SerializeField]
    GameEvent onJump;

    [SerializeField]
    GameEvent onQuit;

    [SerializeField]
    GameEvent onScreenshot;

    [SerializeField]
    GameEvent onPause;

    [SerializeField]
    GameEvent onReset;

    [SerializeField]
    GameEvent onSwap;

    public void OnMove(InputAction.CallbackContext context)
    {
        if (context.ReadValueAsButton())
        {
            onMove.Invoke(context.ReadValue<Vector2>());
        }
    }


    public void OnAbility(InputAction.CallbackContext context)
    {
        if (context.ReadValueAsButton())
        {
            onAbility.Invoke();
        }
    }


    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.ReadValueAsButton())
        {
            onJump.Invoke();
        }
    }


    public void OnQuit(InputAction.CallbackContext context)
    {
        if (context.ReadValueAsButton())
        {
            onQuit.Invoke();
        }
    }

    public void OnPause(InputAction.CallbackContext context)
    {
        if (context.ReadValueAsButton())
        {
            onPause.Invoke();
        }
    }


    public void OnReset(InputAction.CallbackContext context)
    {
        if (context.ReadValueAsButton())
        {
            onReset.Invoke();
        }
    }


    public void OnScreenshot(InputAction.CallbackContext context)
    {
        if (context.ReadValueAsButton())
        {
            onScreenshot.Invoke();
        }
    }


    public void OnSwap(InputAction.CallbackContext context)
    {
        if (context.ReadValueAsButton())
        {
            onSwap.Invoke();
        }
    }


}