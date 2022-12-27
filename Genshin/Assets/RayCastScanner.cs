using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using static Unity.Burst.Intrinsics.X86.Avx;
using static UnityEngine.InputSystem.LowLevel.InputStateHistory;

public class RayCastScanner : MonoBehaviour
{
    public ScanCameraActivator ScanCameraActivatorScript;
    public Text ScanText;
    public float range;
    public float ScanTimer;
    public float Loading;

    void Start()
    {
        ScanTimer = 3;
    }

    void Update()
    {
        if (ScanTimer <= 0)
            ScanTimer = 0;

        if (Input.GetMouseButtonUp(0))
        {
            ScanTimer = 3;
            ScanText.text = "";
            Loading = 0;
        }


        if (ScanCameraActivatorScript.InScanMode == true)
        {
            if (Input.GetMouseButton(0))
            {
                ScanTimer = ScanTimer - 1 * Time.deltaTime;
                Loading += 0.115f;
                string str = Loading.ToString("0.0");
                ScanText.text = "Scanning " + $"{str}" + "%";
                if (ScanTimer <= 0)
                    Scan();
            }
        }
    }

    public void Scan()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, range))
        {
            ScanText.text = $"{hit.collider}";
        }
        else
        {
            ScanText.text = "";
        }
    }
}
