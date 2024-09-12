using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputListener : MonoBehaviour
{
    [SerializeField] private Player player;
    private PlayerInvoker _playerInvoker;
    private void Awake()
    {
        _playerInvoker.GetPlayer(player);
    }
    private void Update()
    {
        ReadJumpInput();
    }

    private void ReadJumpInput()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _playerInvoker.InvokeJump();
        }
    }
}
