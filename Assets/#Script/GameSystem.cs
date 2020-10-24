using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSystem : MonoBehaviour
{
    [SerializeField] private bool isMove = false;
    [SerializeField] private GameObject[] laserObjects = new GameObject[2];
    private int score = 0;

    [SerializeField] private Text scoreText;

    private void Awake()
    {
        PlayerPrefs.SetInt("Score", 0);
    }

    private void Update()
    {
        scoreText.text = "현재 점수 : " + PlayerPrefs.GetInt("Score");
    }

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

    public void PlusScore()
    {
        score += 20;
        PlayerPrefs.SetInt("Score", score);
    }

    public void LaserObjects()
    {
        for (int i = 0; i < laserObjects.Length; i++)
            laserObjects[i].SetActive(true);
    }
}
