using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.XR;

public class PlayerHands : MonoBehaviour
{
    [SerializeField]
    private GameObject bullet;

    //Private

    private PlayerController _controller;
    private GameManager _gm;
    private GameObject _gmObject;

    private void Awake()
    {
        _gmObject = GameObject.Find("GameManager");
        _gm = _gmObject.GetComponent<GameManager>();
        if (!TryGetComponent(out _controller))
            Debug.LogError("Missing PlayerController", this);

        _controller.onShootStart += OnShootStart;
        _controller.onShootStop += OnShootStop;
    }

    private void OnShootStart()
    {
        if (_gm.isPaused == false)
        {
            Instantiate(bullet, transform.position, transform.rotation);
            //Instantiate un bullet 
        }

    }

    private void OnShootStop()
    {

    }

}
