using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputListener : MonoBehaviour
{
    private void Update()
    {
        ReadJumpInput();
    }

    private void ReadJumpInput()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Call jump void from another script
        }
    }
}
