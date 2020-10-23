using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private GameSystem gameSystem;
    private RotateToMouse rotateToMouse;
    private Movement movement;

    private void Awake()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        gameSystem = GameObject.FindWithTag("GameSystem").GetComponent<GameSystem>();
        rotateToMouse = this.GetComponent<RotateToMouse>();
        movement = this.GetComponent<Movement>();
    }

    private void Update()
    {
        UpdateRotate();

        if (gameSystem.GetIsMove() == true)
        {
            UpdateMove();
        }
    }

    private void UpdateRotate()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        rotateToMouse.UpdateRotate(mouseX, mouseY);
    }

    private void UpdateMove()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        movement.UpdateMove(horizontal, vertical);
    }

 
}
