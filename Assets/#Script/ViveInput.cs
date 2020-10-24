using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class ViveInput : MonoBehaviour
{
    [SerializeField] private SteamVR_Input_Sources handType;
    [SerializeField] private SteamVR_Action_Boolean pinchButton;
    [SerializeField] private SteamVR_Action_Boolean gripButton;
    [SerializeField] private SteamVR_Action_Boolean teleportButton;


    private QuestSystem questSystem;
    private GameSystem gameSystem;
    private Movement movement;
    public bool isClick = false;

    private void Awake()
    {
        questSystem = GameObject.FindWithTag("QuestSystem").GetComponent<QuestSystem>();
        movement = GameObject.FindWithTag("Player").GetComponent<Movement>();
        gameSystem = GameObject.FindWithTag("GameSystem").GetComponent<GameSystem>();
    }

    private void Update()
    {
        if (GetButtonDown(pinchButton))
        {
            questSystem.IsClick();
        }

        if (GetButtonDown(teleportButton) && gameSystem.GetIsMove() == true)
        {
            movement.IsForward = true;
            movement.IsMove = true;
        }
        else if (GetButtonUp(teleportButton))
        {
            movement.IsMove = false;
        }

        if (GetButtonDown(gripButton) && gameSystem.GetIsMove() == true)
        {
            movement.IsForward = false;
            movement.IsMove = true;
        }
        else if(GetButtonUp(gripButton))
        {
            movement.IsMove = false;
        }


    }

    private bool GetButtonDown(SteamVR_Action_Boolean button)
    {
        return button.GetStateDown(handType);
    }

    private bool GetButtonUp(SteamVR_Action_Boolean button)
    {
        return button.GetStateUp(handType);
    }
}
