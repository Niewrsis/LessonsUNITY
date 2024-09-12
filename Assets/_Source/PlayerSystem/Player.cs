using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour
{
    [field: SerializeField] public float MovementSpeed { get; private set; }
    [SerializeField] private float rotationSpeed;
    [field: SerializeField] public float jumpForce { get; private set; }

    private Rigidbody _rb;
    public Rigidbody Rb => _rb;
}
