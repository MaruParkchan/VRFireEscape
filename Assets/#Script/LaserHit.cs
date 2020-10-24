using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LaserHit : MonoBehaviour
{
    private QuestSystem questSystem;

    private void Awake()
    {
        questSystem = GameObject.FindWithTag("QuestSystem").GetComponent<QuestSystem>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.CompareTag("Yes"))
        {
            other.transform.GetComponent<Text>().color = Color.green;
            questSystem.isYes = true;
        }

        if (other.transform.CompareTag("No"))
        {
            other.transform.GetComponent<Text>().color = Color.green;
            questSystem.isNo = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.transform.CompareTag("Yes"))
        {
            other.transform.GetComponent<Text>().color = Color.black;
            questSystem.isYes = false;
        }

        if (other.transform.CompareTag("No"))
        {
            other.transform.GetComponent<Text>().color = Color.black;
            questSystem.isNo = false;
        }
    }
}
