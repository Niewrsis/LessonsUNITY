using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInvoker
{
    private PlayerMovement _playerMovement;
    private Player _player;

    public PlayerInvoker()
    {
        _playerMovement = new();
    }
    public void InvokeJump()
    {
        _playerMovement.Jump(_player.Rb, 2f);
    }
}
