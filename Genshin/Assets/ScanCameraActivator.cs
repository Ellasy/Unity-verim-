using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScanCameraActivator : MonoBehaviour
{
    public RayCastScanner RayCastScannerScript;
    public Camera MainCamera;
    public GameObject ScanCamera;
    public bool InScanMode;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Tab))
        {
            InScanMode = true;
        }
        else
        {
            InScanMode = false;
        }
        if (InScanMode == true)
        {
            MainCamera.enabled = false;
            ScanCamera.SetActive(true);
        }
        else
        {
            MainCamera.enabled = true;
            ScanCamera.SetActive(false);
            RayCastScannerScript.ScanText.text = "";
        }
    }
}
