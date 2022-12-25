using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Statistics : MonoBehaviour
{
    public bool CursorVisible;
    public Text CoinsText;
    public int Coins;
    public bool Key;

    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = CursorVisible;
    }

    void Update()
    {
        CoinsText.text = "Coins " + $"{Coins}";
    }
}
