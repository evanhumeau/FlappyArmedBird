using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public class PlayerHands : MonoBehaviour
{

    //Private

    private Rigidbody _rb;
    private PlayerController _controller;

    private void Awake()
    {
        if (!TryGetComponent(out _rb))
            Debug.LogError("Missing Rigidbody", this);
        if (!TryGetComponent(out _controller))
            Debug.LogError("Missing PlayerController", this);

        _controller.onShootStart += OnShootStart;
        _controller.onShootStop += OnShootStop;
    }

    private void OnShootStart()
    {
        //Instantiate un bullet 
    }

    private void OnShootStop()
    {

    }

}
