using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierTrigger : MonoBehaviour
{
    public GameObject KeyText;
    public GameObject Glass;
    public Statistics StatisticsScript;
    void Start()
    {
        GameObject StatisticsObject = GameObject.FindGameObjectWithTag("Player");
        StatisticsScript = StatisticsObject.GetComponent<Statistics>();
    }

    void OnTriggerEnter(Collider other)
    {
        KeyText.SetActive(true);
    }

    void OnTriggerExit(Collider other)
    {
        KeyText.SetActive(false);
    }

    void OnTriggerStay(Collider other)
    {
        if (StatisticsScript.Coins >= 5)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                StatisticsScript.Coins = StatisticsScript.Coins - 5;
                Glass.SetActive(false);
                KeyText.SetActive(false);
                gameObject.SetActive(false);
            }
        }
    }
}
