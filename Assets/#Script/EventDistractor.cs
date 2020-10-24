using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventDistractor : MonoBehaviour
{
    [SerializeField] private GameObject distractorPaper; // 설문지 오브젝트 

    private GameSystem gameSystem;

    private void Awake()
    {
        gameSystem = GameObject.FindWithTag("GameSystem").GetComponent<GameSystem>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.CompareTag("Player"))
        {
            distractorPaper.SetActive(true);
            gameSystem.LaserObjects();
            gameSystem.IsMoveOff();
            Destroy(this.gameObject);
        }
    }
}
