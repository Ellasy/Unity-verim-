using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectByTrigger : MonoBehaviour
{
    public Statistics StatisticsScript;

    void Start()
    {
        GameObject StatisticsObject = GameObject.FindGameObjectWithTag("Player");
        StatisticsScript = StatisticsObject.GetComponent<Statistics>();
    }

    void OnTriggerEnter(Collider player)
    {
        StatisticsScript.Coins += 1;
        gameObject.SetActive(false);
    }

    void Update()
    {
        if (gameObject.tag == "Coin")
            gameObject.transform.Rotate(0, Time.deltaTime * 60, 0);
    }

}
