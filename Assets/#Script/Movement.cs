﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class Movement : MonoBehaviour
{
    private CharacterController characterController;

    [SerializeField] private float moveSpeed = 5;
    [SerializeField] private float gravity = -20.0f;
    private Vector3 moveForce;

    public float MoveSpeed
    {
        set { moveSpeed = value; }
        get { return moveSpeed; }
    }

    private void Awake()
    {
        characterController = this.GetComponent<CharacterController>();
    }

    public void UpdateMove(float horizontal, float vertical)
    {
        Vector3 direction = transform.rotation * new Vector3(horizontal, 0, vertical);

        moveForce = new Vector3(direction.x * moveSpeed, moveForce.y, direction.z * moveSpeed);

        if(!characterController.isGrounded)
        {
            moveForce.y += gravity * Time.deltaTime;
        }

        characterController.Move(moveForce * Time.deltaTime);
    }
}
