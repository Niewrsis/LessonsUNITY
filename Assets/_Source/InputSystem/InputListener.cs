using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputListener : MonoBehaviour
{
    [SerializeField] private Player player;
    private PlayerInvoker _playerInvoker;

    private void Awake()
    {
        _playerInvoker = new(player);
    }
    private void Update()
    {
        ReadJumpInput();
        ReadMoveInput();
        ReadRotationInput();
    }

    private void ReadJumpInput()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _playerInvoker.InvokeJump();
        }
    }
    private void ReadMoveInput()
    {
        if (Input.GetKey(KeyCode.W))
        {
            _playerInvoker.InvokeMoveForward();
        }
        if (Input.GetKey(KeyCode.S))
        {
            _playerInvoker.InvokeMoveBackward();
        }
    }
    private void ReadRotationInput()
    {
        if (Input.GetKey(KeyCode.A))
        {
            _playerInvoker.InvokeRotationLeft();
        }
        if (Input.GetKey(KeyCode.D))
        {
            _playerInvoker.InvokeRotationRight();
        }
    }
}