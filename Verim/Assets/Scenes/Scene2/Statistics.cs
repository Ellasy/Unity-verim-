using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Statistics : MonoBehaviour
{
    public bool CursorVisible;
    public bool Key;
    public Text CoinsText;
    public int Coins;


    void Awake()
    {
        LoadCoins();
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = CursorVisible;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Delete))
            PlayerPrefs.DeleteAll();
        CoinsText.text = "Coins " + $"{Coins}";
    }

    public void SaveCoins()
    {
        PlayerPrefs.SetInt("Coins", Coins);
    }

    public void LoadCoins()
    {
        Coins = PlayerPrefs.GetInt("Coins");
    }
}
