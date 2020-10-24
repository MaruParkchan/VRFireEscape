using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestSystem : MonoBehaviour
{
    [SerializeField] private int questCount = 0;

    [SerializeField] private GameObject[] laserObjects;
    [SerializeField] private GameObject[] questPanels;

    private GameSystem gameSystem;

    public bool isYes = false;
    public bool isNo = false;

    private void Awake()
    {
        gameSystem = GameObject.FindWithTag("GameSystem").GetComponent<GameSystem>();
    }

    public void IsClick()
    {
        if (isYes == false && isNo == false)
            return;

        if(isYes == true && isNo == false)
        {
            gameSystem.PlusScore();
        }
        else if(isYes == false && isNo == true)
        {

        }

        questPanels[questCount].SetActive(false);
        gameSystem.IsMoveOn();
        questCount++;

        for (int i = 0; i < laserObjects.Length; i++)
            laserObjects[i].SetActive(false);

    }


}
