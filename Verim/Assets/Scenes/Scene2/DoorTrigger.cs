using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public GameObject DoorText;
    public GameObject Door;
    public Statistics StatisticsScript;
    void Start()
    {
        GameObject StatisticsObject = GameObject.FindGameObjectWithTag("Player");
        StatisticsScript = StatisticsObject.GetComponent<Statistics>();
    }

    void OnTriggerEnter(Collider other)
    {
        DoorText.SetActive(true);
    }

    void OnTriggerExit(Collider other)
    {
        DoorText.SetActive(false);
    }

    void OnTriggerStay(Collider other)
    {
        if (StatisticsScript.Key == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Door.SetActive(false);
                DoorText.SetActive(false);
                gameObject.SetActive(false);    
            }
        }
    }
}
