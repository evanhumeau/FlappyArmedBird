using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour
{
    //Params

    [SerializeField]
    private float jumpForce = 10f;
    [SerializeField]
    private float gravityForce = -1.8f;

    //Private

    private Rigidbody _rb;
    private PlayerController _controller;

    private Vector3 _direction;

    //Public 

    public bool isJumping;

    private void Awake()
    {
        if (!TryGetComponent(out _rb))
            Debug.LogError("Missing Rigidbody", this);
        if (!TryGetComponent(out _controller))
            Debug.LogError("Missing PlayerController", this);

        _controller.onJumpStart += OnJumpStart;
        _controller.onJumpStop += OnJumpStop;
    }

    private void FixedUpdate()
    {
        //_direction.y = gravityForce * Time.deltaTime;
        //transform.position += _direction * Time.deltaTime;

        _rb.velocity += gravityForce * Vector3.up;
    }

    private void OnJumpStart()
    {
        _rb.velocity = Vector3.up * jumpForce;

        isJumping = true;

        //_rb.AddRelativeForce(0, jumpForce, 0, ForceMode.Impulse);
    }

    private void OnJumpStop()
    {
        isJumping = false;
    }

}
