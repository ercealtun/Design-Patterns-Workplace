using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static Action OnForwardMovement;
    public static Action OnBackwardMovement;
    public static Action OnLeftMovement;
    public static Action OnRightMovement;

    public void ForwardOnClick()
    {
        OnForwardMovement?.Invoke();
    }
    
    public void BackwardOnClick()
    {
        OnBackwardMovement?.Invoke();
    }
    
    public void LeftOnClick()
    {
        OnLeftMovement?.Invoke();
    }
    
    public void RightOnClick()
    {
        OnRightMovement?.Invoke();
    }
    
}
