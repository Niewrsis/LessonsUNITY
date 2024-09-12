using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInvoker
{
    private PlayerMovement _playerMovement;
    private Player _player;

    public PlayerInvoker(Player player)
    {
        _playerMovement = new();
        _player = player;
    }
    public void InvokeJump()
    {
        _playerMovement.Jump(_player.Rb, _player.JumpForce);
    }
    public void InvokeMoveForward()
    {
        _playerMovement.MoveForward(_player.Rb, _player.MovementSpeed);
    }
    public void InvokeMoveBackward()
    {
        _playerMovement.MoveBackward(_player.Rb, _player.MovementSpeed);
    }
    public void InvokeRotationLeft()
    {
        _playerMovement.RotateLeft(_player.Transform, _player.RotationSpeed);
    }
    public void InvokeRotationRight()
    {
        _playerMovement.RotateRight(_player.Transform, _player.RotationSpeed);
    }
}
