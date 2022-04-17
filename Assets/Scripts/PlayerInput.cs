using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private InputActions inputActions;
    private InputAction movement;

    private void Awake()
    {
        inputActions = new InputActions();
    }

    private void OnEnable()
    {
        movement = inputActions.main.Space;
        movement.Enable();

        inputActions.main.Space.performed += DoJump;
        inputActions.main.Space.Enable();



    }

    private void DoJump(InputAction.CallbackContext obj)
    {
        Debug.Log("Jump!!!");
    }

    private void OnDisable()
    {
        movement.Disable();
        inputActions.main.Space.Disable();
    }

    private void FixedUpdate()
    {
        Debug.Log("Jumo");
    }
}
