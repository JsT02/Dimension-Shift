using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{

    private CustomInput input = null;
    public float MovementSpeed = 100f;
    private Vector2 MovementVector;
    private Rigidbody2D rb = null;
    public float Gravity = 10f;
    public GameObject settings;

    private void Awake()
    {
        input = new CustomInput();
        rb = GetComponent<Rigidbody2D>();

    }

    private void OnEnable()
    {
        input.Enable();
        input.Player.Movement.performed += OnMovementPerformed;
        input.Player.Movement.canceled += OnMovementCanceled;

    }

    private void Update()
    {
        rb.velocity = MovementVector * MovementSpeed;

        Settings();

    }

    private void OnDisable()
    {
        input.Disable();
        input.Player.Movement.performed -= OnMovementPerformed;
        input.Player.Movement.canceled -= OnMovementCanceled;

    }

    void OnMovementPerformed(InputAction.CallbackContext value)
    {

        MovementVector = value.ReadValue<Vector2>();

    }

    void OnMovementCanceled(InputAction.CallbackContext value)
    {

        MovementVector = Vector2.zero;

    }

    void Settings()
    {

        if (input.Player.Settings.IsPressed()) settings.SetActive(true);

    }

}
