using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Statistics : MonoBehaviour
{
    public Text CoinsText;
    public int Coins;
    public bool Key;

    void Start()
    {
        
    }

    void Update()
    {
        CoinsText.text = "Coins " + $"{Coins}";
    }
}
