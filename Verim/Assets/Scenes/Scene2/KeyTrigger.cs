using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyTrigger : MonoBehaviour
{
    public Statistics StatisticsScript;
    public Text KeyInventory;

    void Start()
    {
        GameObject StatisticsObject = GameObject.FindGameObjectWithTag("Player");
        StatisticsScript = StatisticsObject.GetComponent<Statistics>();
    }

    void OnTriggerEnter()
    {
        StatisticsScript.Key = true;
        KeyInventory.text = "Key";
        gameObject.SetActive(false);
    }

}
