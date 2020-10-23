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


    private void Update()
    {
        if (GetButtonDown(pinchButton))
        {
            Debug.Log("트리거 버튼");
        }

        if (GetButtonDown(gripButton))
        {
            Debug.Log("옆 버튼");
        }


        if (GetButtonDown(teleportButton))
        {
            Debug.Log("텔레포트 버튼");
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
