using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameSystem : MonoBehaviour
{
    [SerializeField] private GameObject[] laserObjects = new GameObject[2];
    private bool isMove = false;
    private int score = 0;

    [SerializeField] private Text gamePlayTimerText;
    [SerializeField] private float playTimer = 120;
    [SerializeField] private Text scoreText;
    private AudioSource sirenSoundAudioSource;

    private void Awake()
    {
        PlayerPrefs.SetInt("Score", 0);
        sirenSoundAudioSource = GetComponent<AudioSource>();
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

    IEnumerator GameStageSystemStart()
    {
        yield return new WaitForSeconds(3.0f);
        sirenSoundAudioSource.Play();
    }

    IEnumerator GameOverTimer()
    {
        yield return new WaitForSeconds(playTimer);
        SceneManager.LoadScene("Result");
    }
}
