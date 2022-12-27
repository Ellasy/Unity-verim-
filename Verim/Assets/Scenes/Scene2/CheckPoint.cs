using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public Statistics StatisticsScript;
    public CollectByTrigger CollectByTriggerScript;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            StatisticsScript.SaveCoins();
            CollectByTriggerScript.SaveVisibleCoins();
        }
        if (PlayerPrefs.HasKey("Collect"))
            Debug.Log("Сохранился");
    }

    void Start()
    {
        GameObject StatisticsObject = GameObject.FindGameObjectWithTag("Player");
        StatisticsScript = StatisticsObject.GetComponent<Statistics>();
    }
}
