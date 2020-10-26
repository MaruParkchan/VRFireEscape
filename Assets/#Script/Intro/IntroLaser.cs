using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntroLaser : MonoBehaviour
{
    private IntroSystem introSystem;

    private void Awake()
    {
        introSystem = GameObject.FindWithTag("IntroSystem").GetComponent<IntroSystem>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Start"))
        {
            introSystem.isStart = true;
            other.transform.GetComponent<Text>().color = Color.green;        
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.transform.CompareTag("Start"))
        {
            introSystem.isStart = false;
            other.transform.GetComponent<Text>().color = Color.black;
        }
    }
}
