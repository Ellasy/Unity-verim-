using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerZone : MonoBehaviour
{
    public GameObject MyText;

    void OnTriggerEnter()
    {
        MyText.SetActive(true);
    }

    void Update()
    {
        
    }
}
