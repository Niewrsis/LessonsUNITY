using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour
{
    [field: SerializeField] public float MovementSpeed { get; private set; }
    [SerializeField] private float rotationSpeed;
    [SerializeField] private float jumpForce;

    private Rigidbody _rb;
    public Rigidbody Rb => _rb;

    private void Awake()
    {
        //case1
        /*
        if (gameObject.TryGetComponent<Rigidbody>(out var rb))
        {
            _rb = rb;
        }
        */


    }
}
