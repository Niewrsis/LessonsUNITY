using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInvoker
{
    private PlayerMovement _playerMovement;

    public PlayerInvoker()
    {
        _playerMovement = new();
    }
    public void InvokeJump(Player player)
    {
        _playerMovement.Jump(player.Rb, player.JumpForce);
    }
}
