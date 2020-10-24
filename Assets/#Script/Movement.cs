using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class Movement : MonoBehaviour
{
    private CharacterController characterController;

    [SerializeField] private float moveSpeed = 5;
    [SerializeField] private float gravity = -20.0f;

    [SerializeField] Transform mainCameraPos;
    private Vector3 direction;
    private GameSystem gameSystem;

    private bool isForward;
    public bool IsForward
    {
        set { isForward = value; }
        get { return isForward; }
    }
    public float MoveSpeed
    {
        set { moveSpeed = value; }
        get { return moveSpeed; }
    }
    private bool isMove = false;
    public bool IsMove
    {
        set { isMove = value; }
        get { return isMove; }
    }

    private void Awake()
    {
        characterController = this.GetComponent<CharacterController>();
        gameSystem = GameObject.FindWithTag("GameSystem").GetComponent<GameSystem>();
    }

    private void Update()
    {
        if (gameSystem.GetIsMove() == true)
            UpdateMove();
    }

    private void UpdateMove()
    {
        if (isForward == true)
            direction = mainCameraPos.forward;
        else
            direction = mainCameraPos.forward * -1;

        direction = direction.normalized;

        if (!characterController.isGrounded)
        {
            direction.y += gravity * Time.deltaTime;
        }

        if (isMove == true)
            characterController.Move(direction * Time.deltaTime * moveSpeed);
    }

    //private void FixedUpdateMove()
    //{
    //    if (characterController.isGrounded)
    //    {
    //        direction = mainCameraPos.forward;
    //        direction = direction.normalized;
    //        characterController.Move(direction * moveSpeed * Time.deltaTime * directionZ);
    //        //    direction.y -= 9.82f * Time.deltaTime;
    //        //    characterController.Move(direction * baseSpeed * Time.deltaTime);
    //    }
    //    //   else if(characterController.isGrounded == false)
    //    else
    //    {
    //        direction = Vector3.zero;
    //        direction.y -= 9.82f * Time.deltaTime;
    //        characterController.Move(direction);
    //    }
    //}

}
