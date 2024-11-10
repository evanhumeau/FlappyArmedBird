using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour, PlayerInputActions.IPlayerActions
{
    // Events

    public event Action onJumpStart;
    public event Action onJumpStop;
    public event Action onShootStart;
    public event Action onShootStop;


    public void OnMove(InputAction.CallbackContext ctx)
    {
        if (ctx.started)
            onJumpStart?.Invoke();
        else if (ctx.canceled)
            onJumpStop?.Invoke();
    }

    public void OnShoot(InputAction.CallbackContext ctx)
    {
        if (ctx.started)
            onShootStart?.Invoke();
        else if (ctx.canceled)
            onShootStop?.Invoke();
    }

}
