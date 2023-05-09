using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLocomotion : MonoBehaviour
{
    private void OnEnable()
    {
        InputManager.OnForwardMovement += MoveForward;
        InputManager.OnBackwardMovement += MoveBackward;
        InputManager.OnLeftMovement += MoveLeft;
        InputManager.OnRightMovement += MoveRight;
    }

    private void OnDisable()
    {
        InputManager.OnForwardMovement -= MoveForward;
        InputManager.OnBackwardMovement -=  MoveBackward;
        InputManager.OnLeftMovement -=  MoveLeft;
        InputManager.OnRightMovement -=  MoveRight;
    }

    private void MoveForward() => transform.Translate(Vector3.forward);
    private void MoveBackward() => transform.Translate(Vector3.back);
    private void MoveLeft() => transform.Translate(Vector3.left);
    private void MoveRight() => transform.Translate(Vector3.right);
}
