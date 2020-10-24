using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventEffect : MonoBehaviour
{
    [SerializeField] private GameObject[] setActiveObjects;


    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.CompareTag("Player"))
        {
            for (int i = 0; i < setActiveObjects.Length; i++)
                setActiveObjects[i].SetActive(true);
        }
    }
}
