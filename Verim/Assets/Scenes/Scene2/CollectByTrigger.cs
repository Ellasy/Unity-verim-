using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CollectByTrigger : MonoBehaviour
{
    public Statistics StatisticsScript;
    public bool Collect;

    void Start()
    {
        LoadVisibleCoins();
        GameObject StatisticsObject = GameObject.FindGameObjectWithTag("Player");
        StatisticsScript = StatisticsObject.GetComponent<Statistics>();
        if (Collect == true)
            gameObject.SetActive(false);
    }

    void OnTriggerEnter(Collider player)
    {
        StatisticsScript.Coins += 1;
        Collect = true;
        gameObject.SetActive(false);
    }

    public void SaveVisibleCoins()
    {
        PlayerPrefs.SetInt("Collect", Collect?1:0) ;
    }

    public void LoadVisibleCoins()
    {
       Collect = PlayerPrefs.GetInt("Collect")==1?true:false;
    }
}
