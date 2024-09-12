using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement
{
    public void Jump(Rigidbody rb, float jumpForce)
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
    public void MoveForward(Rigidbody rb, float moveForce)
    {
        rb.AddForce(rb.transform.forward * moveForce * Time.deltaTime, ForceMode.Impulse);
    }
    public void MoveBackward(Rigidbody rb, float moveForce)
    {
        rb.AddForce(-rb.transform.forward * moveForce * Time.deltaTime, ForceMode.Impulse);
    }
    public void RotateLeft(Transform transform, float rotationSpeed)
    {
        transform.Rotate(0f, (-1f) * rotationSpeed * Time.deltaTime, 0f);
    }
    public void RotateRight(Transform transform, float rotationSpeed)
    {
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
    }
}
