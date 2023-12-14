using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{
    // Components //

    private CustomInput input = null;
    private Rigidbody2D rb = null;
    public GameObject settings;
    public GameObject game;
    private bool firstTime = true;
    private AudioSource jump = null;

    // Values //

    // Movement
    private Vector2 MovementVector;
    public float MovementSpeed = 100f;
    public float Gravity = 9.81f;
    public float JumpFactor = 3.0f;

    // Boolean
    public bool isGrounded;
    private bool isJumping = false;
    private bool first = true;

    private void Awake()
    {

        input = new CustomInput();
        rb = GetComponent<Rigidbody2D>();
        jump = GetComponent<AudioSource>();

    }

    private void OnEnable()
    {

        input.Enable();
        input.Player.Movement.performed += OnMovementPerformed;
        input.Player.Movement.canceled += OnMovementCanceled;
        input.Player.Jump.performed += OnJumpPerformed;
        input.Player.Jump.canceled += OnJumpCanceled;
        input.Player.Settings.performed += OnSettingsPerformed;

    }

    private void Update()
    {
        
        rb.velocityX = MovementVector.x * MovementSpeed;

        if (rb.velocityY == 0)
        {

            if (first) first = false;
            else isGrounded = true;

        }
        else isGrounded = false;

        if (isGrounded && isJumping)
        {

            rb.AddForceY(JumpFactor);
            jump.Play();

        }
        // Settings();

    }

    private void OnDisable()
    {
        input.Disable();
        input.Player.Movement.performed -= OnMovementPerformed;
        input.Player.Movement.canceled -= OnMovementCanceled;
        input.Player.Jump.performed -= OnJumpPerformed;
        input.Player.Jump.canceled -= OnJumpCanceled;
        input.Player.Settings.performed -= OnSettingsPerformed;

    }

    void OnMovementPerformed(InputAction.CallbackContext value)
    {

        MovementVector = value.ReadValue<Vector2>();

    }

    void OnMovementCanceled(InputAction.CallbackContext value)
    {

        MovementVector = Vector2.zero;

    }

    void OnJumpPerformed(InputAction.CallbackContext context)
    {

        isJumping = true;

    }

    void OnJumpCanceled(InputAction.CallbackContext context)
    {

        isJumping = false;

    }

    void OnSettingsPerformed(InputAction.CallbackContext context)
    {

        if (settings.active == false)
        {

            settings.SetActive(true);
            game.SetActive(false);

        }
        else
        {

            settings.SetActive(false);
            game.SetActive(true);

        }
    }

}
