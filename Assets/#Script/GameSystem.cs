using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSystem : MonoBehaviour
{
    [SerializeField] private bool isMove = false;

    public bool GetIsMove()
    {
        return isMove;
    }

    public void IsMoveOn()
    {
        isMove= true;
    }

    public void IsMoveOff()
    {
        isMove = false;
    }
}
