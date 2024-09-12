using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputListener : MonoBehaviour
{
    [SerializeField] private Player player;
    private UIManager _uiManager;
    private PlayerInvoker _playerInvoker;
    private bool _isBlockerActive = false;

    private void Awake()
    {
        _playerInvoker = new(player);
        _uiManager = GetComponent<UIManager>();
    }
    private void Update()
    {
        ReadInputBlockerInput();
        if (!_isBlockerActive)
        {
            ReadJumpInput();
            ReadMoveInput();
            ReadRotationInput();
        }
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
    private void ReadInputBlockerInput()
    {
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            _uiManager.WarningTextOpener();
            _isBlockerActive = !_isBlockerActive;
        }
    }
}